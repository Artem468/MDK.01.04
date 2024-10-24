namespace SystemLab2;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new Button();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        label1 = new Label();
        label2 = new Label();
        textBox3 = new TextBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(47, 152);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 0;
        button1.Text = "Найти";
        button1.UseVisualStyleBackColor = true;
        button1.Click += find_all_words;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(47, 44);
        textBox1.Name = "directory";
        textBox1.Size = new Size(100, 23);
        textBox1.TabIndex = 1;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(47, 102);
        textBox2.Name = "wordToFind";
        textBox2.Size = new Size(100, 23);
        textBox2.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(47, 26);
        label1.Name = "label1";
        label1.Size = new Size(33, 15);
        label1.TabIndex = 3;
        label1.Text = "Путь";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(47, 84);
        label2.Name = "label2";
        label2.Size = new Size(93, 15);
        label2.TabIndex = 4;
        label2.Text = "Искомое слово";
        // 
        // textBox3
        // 
        textBox3.Location = new Point(218, 26);
        textBox3.Multiline = true;
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(318, 179);
        textBox3.TabIndex = 5;
        textBox3.Enabled = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(591, 231);
        Controls.Add(textBox3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label1;
    private Label label2;
    private TextBox textBox3;
}