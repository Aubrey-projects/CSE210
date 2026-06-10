class Listing : Activity
{
    // Variables
    private List<string> _listingPrompts = new List<string>();
    private List<string> _userResponses = new List<string>();
    private Random _randomGenerator = new Random();

    // Constructor
    public Listing(string activityType, string activityDesc) : base (activityType, activityDesc)
    {
        
    }

    public string SelectPrompt()
    {
        int randomIndex = _randomGenerator.Next(0, _listingPrompts.Count);
        string prompt = _listingPrompts[randomIndex];
        return prompt;
    }

    public void ListingActivity()
    {
        
    }

    public void AppendUserResponse(string userResponse)
    {
        _userResponses.Add(userResponse);
    }

    public void AppendPrompt(string prompt)
    {
        _listingPrompts.Add(prompt);
    }

    public int CountTotalResponses()
    {
        return _userResponses.Count;
    }
}