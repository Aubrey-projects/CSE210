class Menu
{
    public void RunMenu()
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
                break;

            case 2:
                Reflecting reflectingActivity = new Reflecting();
                break;

            case 3:
                Listing listingActivity = new Listing();
                break;

            case 4:
            // code to quit
                break;
        }
    }
}