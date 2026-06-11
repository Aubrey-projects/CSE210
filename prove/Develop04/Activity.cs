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
    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_activityType}.");
        Console.WriteLine("");
        Console.WriteLine(_activityDesc);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        _sessionDuration = int.Parse(Console.ReadLine());
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
    
    public void RunSpinningAnimation()
    {
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_sessionDuration} seconds of the {_activityType}.");
    }
}
