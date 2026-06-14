class Activity
{
    // Variables
    private string _activityType;
    private string _activityDesc;
    private int _sessionDuration;
    private DateTime _endTime;

    // Constructor
    public Activity(string activityType, string activityDesc)
    {
        _activityType = activityType;
        _activityDesc = activityDesc;
        _sessionDuration = 0;
        _endTime = DateTime.Now;
    }

    // Methods
    public DateTime GetEndTime()
    {
        DateTime now = DateTime.Now;
        _endTime = now.AddSeconds(_sessionDuration);
        return _endTime;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_activityType}.");
        Console.WriteLine("");
        Console.WriteLine(_activityDesc);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        _sessionDuration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        RunSpinningAnimation(2);
        Console.WriteLine("");
    }

    public void RunCountDown(string message, int duration)
    {
        Console.Write($"{message}");
        while(duration >= 0)
        {
            Console.Write($"{duration--,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine("");
    }
    
    public void RunSpinningAnimation(int duration)
    {
        string animationString = "\\|/-";
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(duration);
        int index = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.Write("\b ");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        RunSpinningAnimation(2);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_sessionDuration} seconds of the {_activityType}.");
        RunSpinningAnimation(2);
    }
}
