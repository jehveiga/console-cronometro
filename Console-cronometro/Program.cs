// See https://aka.ms/new-console-template for more information
start();

static void start()
{
    int time = 10;
    int currentTime = 0;

    while(currentTime != time)
    {
        Console.Clear();
        Console.WriteLine(currentTime);
        currentTime++;
    } 
}
