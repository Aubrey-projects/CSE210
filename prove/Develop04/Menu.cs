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
                Breathing breathingActivity = new Breathing("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                break;

            case 2:
                Reflecting reflectingActivity = new Reflecting("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                break;

            case 3:
                Listing listingActivity = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                break;

            case 4:
            // code to quit
                break;
        }
    }
}