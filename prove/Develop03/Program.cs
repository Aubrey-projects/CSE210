using System;
using System.ComponentModel.DataAnnotations;

// To EXCEED THE REQUIREMENTS I made a library of Scriptures and, each time you run the program,
// it'll display a random scripture from the library for you to memorize.

class Program
{
    static void Main(string[] args)
    {
        // Adding all scriptures to a library
        ScriptureReference ScriptureReference1 = new ScriptureReference("John", 14, 27);
        Scripture Scripture1 = new Scripture("Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid.");
        Library myLibrary = new Library(ScriptureReference1, Scripture1);
    
        ScriptureReference ScriptureReference2 = new ScriptureReference("Psalm", 34, 4);
        Scripture Scripture2 = new Scripture("I sought the Lord, and he heard me, and delivered me from all my fears.");
        myLibrary.AddScripture(ScriptureReference2, Scripture2);

        ScriptureReference ScriptureReference3 = new ScriptureReference("Romans", 15, 13);
        Scripture Scripture3 = new Scripture("Now the God of hope fill you with all joy and peace in believing, that ye may abound in hope, through the power of the Holy Ghost.");
        myLibrary.AddScripture(ScriptureReference3, Scripture3);

        ScriptureReference ScriptureReference4 = new ScriptureReference("Matthew", 11, 29, 30);
        Scripture Scripture4 = new Scripture("Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.");
        myLibrary.AddScripture(ScriptureReference4, Scripture4);

        ScriptureReference ScriptureReference5 = new ScriptureReference("Moroni", 7, 42, 43);
        Scripture Scripture5 = new Scripture("Wherefore, if a man have faith he must needs have hope; for without faith there cannot be any hope. And again, behold I say unto you that he cannot have faith and hope, save he shall be meek, and lowly of heart.");
        myLibrary.AddScripture(ScriptureReference5, Scripture5);

        // Selecting a random scripture from the library
        myLibrary.SelectRandomScripture();

        bool finished = false;

        // Starting the loop
        while (finished != true)
        {
        // Displaying text
        myLibrary.ShowSelectedEntry();
        Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");

        // Getting user response
        string userResponse = Console.ReadLine();
        // Evaluating user response
        if ((userResponse.ToLower() == "quit") || myLibrary.GetSelectedEntry().IsHidden())
            {
                // If the user types quit or all words are hidden, loop ends
                finished = true;
            }
        else if (userResponse == "")
            {
                // If the user hits enter, 3 new words are hidden
                myLibrary.GetSelectedEntry().HideRandomWord();
                myLibrary.GetSelectedEntry().HideRandomWord();
                myLibrary.GetSelectedEntry().HideRandomWord();
            }
        // console cleared
        Console.Clear();
        }
    }
}