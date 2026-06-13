class Menu
{
    public void RunMenu()
    {
        Console.Clear();
        bool continueProgram = false;
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
                    break;

                case 2:
                    Reflecting reflectingActivity = new Reflecting();
                    Console.Clear();
                    reflectingActivity.RunReflectingActivity();
                    break;

                case 3:
                    Listing listingActivity = new Listing();
                    Console.Clear();
                    listingActivity.RunListingActivity();
                    break;

                case 4:
                    continueProgram = true;
                    break;
            }
        }
    }
}