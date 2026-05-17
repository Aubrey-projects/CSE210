using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        myMenu.ProcessMenu();

        // JournalEntry myJournalEntry = new JournalEntry();
        // myJournalEntry.CreateJournalEntry();
        // // myJournalEntry.DisplayJournalEntry();
        // // Console.WriteLine(myJournalEntry.CreateFileSystemString());

        // JournalEntry myJournalEntry2 = new JournalEntry();
        // myJournalEntry2.CreateJournalEntry();

        // Journal myJournal = new Journal();
        // myJournal.AddJournalEntry(myJournalEntry);
        // myJournal.AddJournalEntry(myJournalEntry2);
    }
}