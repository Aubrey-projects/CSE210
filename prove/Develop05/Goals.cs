class Goals
{
    private List<Goal> _goalsList = new List<Goal>();
    private int _totalGoalPoints = 0;

    public void ListGoals()
    {
        int count = 1;
        foreach(Goal goal in _goalsList)
        {
            if (goal is Checklist)
            {
                Console.WriteLine($"{count}. [] {goal.GetGoalType()} ({goal.GetGoalDescription()}) -- Currently completed: #/#");
            } else
            {
                Console.WriteLine($"{count}. [] {goal.GetGoalType()} ({goal.GetGoalDescription()})"); 
            }
            count++;
        }
    }

    public void SaveGoals()
    {
        string filename = PromptFileName();
    }

    public void LoadGoals()
    {
        string filename = PromptFileName();
    }

    public void RecordEvent()
    {
        int count = 1;
        Console.WriteLine("The Goals Are:");
        foreach(Goal goal in _goalsList)
        {
            Console.WriteLine($"{count}. {goal.GetGoalType()}");
            count++;
        }
        Console.Write("Which goal did you accomplish? ");
        int userChoice = int.Parse(Console.ReadLine()); // try catch
        Goal chosenGoal = _goalsList[userChoice - 1];
        _totalGoalPoints += chosenGoal.GetGoalPoints();
        Console.WriteLine($"Congratulations! You have earned {chosenGoal.GetGoalPoints()} points!");
        Console.WriteLine($"You now have {_totalGoalPoints} points.");
    }

    public void AddGoal(Goal newGoal)
    {
        _goalsList.Add(newGoal);
    }

    public string PromptFileName()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        return filename;
    }

    public int GetTotalGoalPoints()
    {
        return _totalGoalPoints;
    }
}