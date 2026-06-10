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
        Console.WriteLine(_activityDesc);
        Console.Write($"How many seconds for this activity? "); // Change this so it matches
        _sessionDuration = int.Parse(Console.ReadLine());
    }

    public void RunCountDown(string message, int duration)
    {
        Console.Write($"{message}: ");
        while(duration >= 0)
        {
            Console.Write($"{duration--,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine("");
    }
    
    public void RunLoadingAnimation()
    {
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
    }
}
