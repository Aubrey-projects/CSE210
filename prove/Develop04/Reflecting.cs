class Reflecting : Activity
{
    // Variables
    private List<string> _reflectionPrompts = new List<string>();
    private List<string> _reflectionQuestions = new List<string>();
    private Random _randomGenerator = new Random();

    // Constructor
    public Reflecting() : base ("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }

    public void AppendPrompt(string prompt)
    {
        _reflectionPrompts.Add(prompt);
    }

    public void AppendQuestion(string question)
    {
        _reflectionQuestions.Add(question);
    }

    public string SelectPrompt()
    {
        int randomIndex = _randomGenerator.Next(0, _reflectionPrompts.Count);
        string prompt = _reflectionPrompts[randomIndex];
        return prompt;
    }

    public string SelectQuestion()
    {
        int randomIndex = _randomGenerator.Next(0, _reflectionQuestions.Count);
        string question = _reflectionQuestions[randomIndex];
        return question;
    }

    public void ReflectingActivity()
    {
        
    }
}