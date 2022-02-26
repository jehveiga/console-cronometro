// See https://aka.ms/new-console-template for more information
start(6);

static void start(int time)
{
    int currentTime = 0;

    while(currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Stopwatch finalizado");
    Thread.Sleep(2500);
}
