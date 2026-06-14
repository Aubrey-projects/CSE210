class Breathing : Activity
{
    // Constructor
    public Breathing() : base ("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }

    public void RunBreathingActivity()
    {
        StartActivity();
        DateTime endTime = GetEndTime();
        while (DateTime.Now < endTime)
        {
            RunCountDown("Breath in...", 4);
            RunCountDown("Now breath out...", 6);
            Console.WriteLine("");
            Thread.Sleep(1000);
        }
        DisplayEndingMessage();
    }
}