using System.Net;

class Menu
{
    string _userChoice;

    public void ProcessMenu()
    { // Defining these outside of the loop so they don't get reset
        Journal myJournal = new Journal();

        // Loop until the user choices to quit
        while (_userChoice != "5" && _userChoice != "quit")
        {
            // Displays the menu
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            _userChoice = Console.ReadLine().ToLower();

            // Decides where to redirect the user
            if (_userChoice == "1" || _userChoice == "write")
            {
                Console.WriteLine("writing entry...");
                JournalEntry myJournalEntry = new JournalEntry();
                myJournalEntry.CreateJournalEntry();
                myJournal.AddJournalEntry(myJournalEntry);

            } else if (_userChoice == "2" || _userChoice == "display")
            {
                Console.WriteLine("displaying journal...");
                myJournal.DisplayJournal();

            } else if (_userChoice == "3" || _userChoice == "load")
            {
                Console.WriteLine("loading from file...");
                myJournal.ReadFile();

            } else if (_userChoice == "4" || _userChoice == "save")
            {
                Console.WriteLine("saving to file...");
                myJournal.WriteToFile();

            } else if (_userChoice == "5" || _userChoice == "quit")
            {
                Console.WriteLine("quiting...");
            } else
            {
                Console.WriteLine("That is not a valid option.");
            }
        }
    }
}