class Activity
{
    // Variables
    private string _activityType;
    private string _activityDesc;
    private int _sessionTime;

    // Constructor
    public Activity(string activityType, string activityDesc)
    {
        _activityType = activityType;
        _activityDesc = activityDesc;
    }

    // Setter
    public void SetTimer(int sessionTime)
    {
        _sessionTime = sessionTime;
    }

    // Methods
    public void RunTimer()
    {
        
    }
    
    public void RunLoadingAnimation()
    {
        
    }

    public void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the {_activityType}.");
    }

    public void DisplayDesc()
    {
        Console.WriteLine(_activityDesc);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
    }
}
