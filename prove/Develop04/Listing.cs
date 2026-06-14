class Listing : Activity
{
    // Variables
    private List<string> _listingPrompts = new List<string>();
    private List<string> _userResponses = new List<string>();
    private Random _randomGenerator = new Random();

    // Constructor
    public Listing() : base ("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }

    // Methods
    public string SelectPrompt()
    {
        int randomIndex = _randomGenerator.Next(0, _listingPrompts.Count);
        string prompt = _listingPrompts[randomIndex];
        return prompt;
    }

    public void RunListingActivity()
    {
        StartActivity();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        string prompt = SelectPrompt();
        Console.WriteLine($" --- {prompt} --- ");
        Console.WriteLine("");
        RunCountDown("You may begin in: ", 5);
        DateTime endTime = GetEndTime();
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            AppendUserResponse(Console.ReadLine());
        }
        Console.WriteLine($"You listed {_userResponses.Count} items!");
        DisplayEndingMessage();
    }

    public void AppendUserResponse(string userResponse)
    {
        _userResponses.Add(userResponse);
    }

    public void AppendPrompt(string prompt)
    {
        _listingPrompts.Add(prompt);
    }
}