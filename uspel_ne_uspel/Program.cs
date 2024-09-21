Console.WriteLine("Нажмите Enter, чтобы начать");
Console.ReadKey(true);
Console.WriteLine("Скоро появится сигнал");

Thread signalThread = new Thread(SignalUser);
signalThread.Start();


void SignalUser()
{
    Random random = new Random();
    int delay = random.Next(1000, 5000);
    Thread.Sleep(delay);
    Console.WriteLine("Нажмите любую клавишу!");
    DateTime startTime = DateTime.Now;
    Console.ReadKey(true);
    TimeSpan reactionData = DateTime.Now - startTime;
    Console.WriteLine($"Ваше время реакции: {reactionData.TotalMilliseconds:F0} миллисекунд");
}
