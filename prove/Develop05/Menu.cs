class Menu
{
    private Goals _goalsList = new Goals();

    public void RunMainMenu()
    {
        bool continueLoop = true;
        do
        {
            Console.WriteLine($"You have {_goalsList.GetTotalGoalPoints()} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                _goalsList.AddGoal(RunGoalMenu());

            } else if (userChoice == 2)
            {
                _goalsList.ListGoals();

            } else if (userChoice == 3)
            {
                _goalsList.SaveGoals();
                
            } else if (userChoice == 4)
            {
                
            } else if (userChoice == 5)
            {
                _goalsList.RecordEvent();
            } else if (userChoice == 6)
            {
                continueLoop = false;
            } else
            {
                Console.WriteLine("That is not a valid choice."); // see in the video if there is text if you enter the wrong input.
                Thread.Sleep(1000);
            }
        } while (continueLoop);
    }

    public Goal RunGoalMenu()
    {
        bool continueLoop = true;
        do
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("\t1. Simple Goal");
            Console.WriteLine("\t2. Eternal Goal");
            Console.WriteLine("\t3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            int userChoice = int.Parse(Console.ReadLine());// make try catch

            // make it so this doesn't run if you choose an incorrect choice.
            string goalName = PromptGoalName();
            string goalDescription = PromptGoalDescription();
            int goalPoints = PromptGoalPoints(); 

            if (userChoice == 1)
            {
                Simple simpleGoal = new Simple(goalName, goalDescription, goalPoints);
                return simpleGoal;

            } else if (userChoice == 2)
            {
                Eternal eternalGoal = new Eternal(goalName, goalDescription, goalPoints);
                return eternalGoal;

            } else if (userChoice == 3)
            {
                int amountTillBonus = PromptAmountTillBonus();
                int bonusPoints = PromptBonusPoints();
                Checklist checklistGoal = new Checklist(goalName, goalDescription, goalPoints, amountTillBonus, bonusPoints);
                return checklistGoal;
            } else
            {
                Console.WriteLine("That is not a valid choice."); // see in the video if there is text if you enter the wrong input.
                Thread.Sleep(1000);
            }
        } while (continueLoop);
        return null;
    }

    public string PromptGoalName()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        return goalName;
    }

    public string PromptGoalDescription()
    {
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        return goalDescription;
    }
    
    public int PromptGoalPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        return goalPoints;
    }

    public int PromptAmountTillBonus()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int amountTillBonus = int.Parse(Console.ReadLine());
        return amountTillBonus;
    }

    public int PromptBonusPoints()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonusPoints = int.Parse(Console.ReadLine());
        return bonusPoints;
    }
}