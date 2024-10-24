using System.Text.RegularExpressions;

namespace SystemLab2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void find_all_words(object sender, EventArgs e)
    {
        List<FileData> results = await SearchWordInDirectoryAsync(textBox1.Text, textBox2.Text);
        
        if (results.Any())
        {
            textBox3.Text = "";
            foreach (var item in results)
            {
                textBox3.AppendText($"Название файла: {item.fileName}");
                textBox3.AppendText(Environment.NewLine);    
                textBox3.AppendText($"Путь к файлу: {item.fileDirectory}");
                textBox3.AppendText(Environment.NewLine);             
                textBox3.AppendText($"Количество: {item.count}");     
                textBox3.AppendText(Environment.NewLine);             
                textBox3.AppendText(Environment.NewLine);                
            }
        }
        else
        {
            textBox3.Text = "Совпадений нет!";
        }
    }

    static async Task<List<FileData>> SearchWordInDirectoryAsync(string directoryPath, string searchWord)
    {
        List<FileData> matches = new List<FileData>();

        try
        {
            var files = Directory.EnumerateFiles(directoryPath, "*.*", SearchOption.AllDirectories);
            List<Task> searchTasks = new List<Task>();

            foreach (var file in files)
            {
                searchTasks.Add(Task.Run(async () =>
                {
                    string fileContent = await ReadFileContentAsync(file);
                    int count = Regex.Matches(fileContent, $@"\b{Regex.Escape(searchWord)}\b").Count;
                    if (count > 0)
                    {
                        lock (matches)
                        {
                            FileInfo fileInfo = new FileInfo(file);
                            FileData fileData = new FileData(fileInfo.Name, fileInfo.DirectoryName!, count);
                            matches.Add(fileData);
                        }
                    }
                }));
            }

            await Task.WhenAll(searchTasks);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        return matches;
    }

    static async Task<string> ReadFileContentAsync(string filePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return await reader.ReadToEndAsync();
            }
        }
        catch (IOException ex)
        {
            return string.Empty;
        }
    }
}

struct FileData
{
    public string fileDirectory;
    public string fileName;
    public int count;

    public FileData(string fileName, string fileDirectory, int count)
    {
        this.fileName = fileName;
        this.fileDirectory = fileDirectory;
        this.count = count;
    }
}
