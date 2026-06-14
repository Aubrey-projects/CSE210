class Menu
{
    public void RunMenu()
    {
        Console.Clear();
        bool continueProgram = false;
        int breathingAmount = 0;
        int reflectingAmount = 0;
        int listingAmount = 0;
        while (continueProgram == false)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            int menuChoice = int.Parse(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    Breathing breathingActivity = new Breathing();
                    Console.Clear();
                    breathingActivity.RunBreathingActivity();
                    breathingAmount++;
                    break;

                case 2:
                    Reflecting reflectingActivity = new Reflecting();
                    reflectingActivity.AppendPrompt("Think of a time when you stood up for someone else.");
                    reflectingActivity.AppendPrompt("Think of a time when you did something really difficult.");
                    reflectingActivity.AppendPrompt("Think of a time when you helped someone in need.");
                    reflectingActivity.AppendPrompt("Think of a time when you did something truly selfless.");
                    reflectingActivity.AppendQuestion("Why was this experience meaningful to you?");
                    reflectingActivity.AppendQuestion("Have you ever done anything like this before?");
                    reflectingActivity.AppendQuestion("How did you get started?");
                    reflectingActivity.AppendQuestion("How did you feel when it was complete?");
                    reflectingActivity.AppendQuestion("What made this time different than other times when you were not as successful?");
                    reflectingActivity.AppendQuestion("What is your favorite thing about this experience?");
                    reflectingActivity.AppendQuestion("What could you learn from this experience that applies to other situations?");
                    reflectingActivity.AppendQuestion("What did you learn about yourself through this experience?");
                    reflectingActivity.AppendQuestion("How can you keep this experience in mind in the future?");
                    Console.Clear();
                    reflectingActivity.RunReflectingActivity();
                    reflectingAmount++;
                    break;

                case 3:
                    Listing listingActivity = new Listing();
                    listingActivity.AppendPrompt("Who are people that you appreciate?");
                    listingActivity.AppendPrompt("What are personal strengths of yours?");
                    listingActivity.AppendPrompt("Who are people that you have helped this week?");
                    listingActivity.AppendPrompt("When have you felt the Holy Ghost this month?");
                    listingActivity.AppendPrompt("Who are some of your personal heroes?");
                    Console.Clear();
                    listingActivity.RunListingActivity();
                    listingAmount++;
                    break;

                case 4:
                    continueProgram = true;
                    Console.Clear();
                    Console.WriteLine("Thank you for particpating!");
                    Console.WriteLine("");
                    Console.WriteLine($"You have completed the Breathing Activity {breathingAmount} times.");
                    Console.WriteLine($"You have completed the Reflecting Activity {reflectingAmount} times.");
                    Console.WriteLine($"You have completed the Listing Activity {listingAmount} times.");
                    Thread.Sleep(5000);
                    break;
            }
        }
    }
}