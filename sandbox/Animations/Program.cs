class Program
{
    public static void Main(string[] args)
    {
        int sleepTime = 250;
        Console.Clear();
        Console.CursorVisible = false;
        // for (int i = 0; i < 20; i++)
        // {
        //     Console.Write("+");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        //     Console.Write("-");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }

        string animationString = "\\|/-";
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(10);
        int index = 0; // don't need the index if we use the for loop
        while(DateTime.Now < endTime)
        {
        // for (int i = 0; i < 20; i++)
        // {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            // Console.Write("-");
            // Thread.Sleep(sleepTime);
            // Console.Write("\b");
        // }
        }

        int count = 15;
        DateTime now2 = DateTime.Now;
        DateTime endTime2 = now2.AddSeconds(count);
        while(DateTime.Now < endTime2)
        {
            Console.Write($"{count--,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }

        Console.CursorVisible = true;
        
    }
    
}


