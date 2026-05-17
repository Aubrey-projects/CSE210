using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

class Journal
{
    List<JournalEntry> _journalEntries = new List<JournalEntry>();
    string _filename = @"C:\Users\orang\Desktop\VisualStudioCodeProjects\CSE210\prove\Develop02\Journal.txt";

    public void AddJournalEntry(JournalEntry journalEntry)
    {
        _journalEntries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.DisplayJournalEntry();
        }
    }

    public void WriteToFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (JournalEntry journalEntry in _journalEntries)
            {
                string fileString = journalEntry.CreateFileSystemString();
                outputFile.WriteLine(fileString);
            }
        }
    }

    public void ReadFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}