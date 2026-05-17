class JournalEntry()
{
    string _date;
    string _prompt;
    string _response;
    string[] _prompts =
    {
        "How are you feeling today?",
        "Who did you talk with today?",
        "Where did you go today?",
        "What was the best part of your day?",
        "What did you do today?",
    };

    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();

        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, 5);
        _prompt = _prompts[randomIndex];
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_response}");
    }

    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}