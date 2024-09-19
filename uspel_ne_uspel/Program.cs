// Я не знаю зачем тут потоки или процессы все работает и без них :)

Console.WriteLine("Через 3 секунды нажмите на кнопку");
Thread.Sleep(3000);
DateTime startTime = DateTime.Now;
Console.WriteLine("Сейчас!");
Console.ReadKey();
TimeSpan reactionData = DateTime.Now - startTime;
Console.WriteLine($"Вам потребовалось: {reactionData.TotalMilliseconds:F0} миллиссекунда");
