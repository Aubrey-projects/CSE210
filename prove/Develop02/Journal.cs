using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

public class Journal
{
    List<JournalEntry> _journalEntries = new List<JournalEntry>();
    string _path = @"C:\Users\orang\Desktop\VisualStudioCodeProjects\CSE210\prove\Develop02\";
    string _filename;

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
        Console.Write("What is the file name? ");
        _filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter($"{_path}{_filename}"))
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
        _journalEntries.Clear();
        Console.Write("What is the file name? ");
        _filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"{_path}{_filename}");
        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            JournalEntry LoadedJournalEntry = new JournalEntry();
            LoadedJournalEntry._date = parts[0];
            LoadedJournalEntry._prompt = parts[1];
            LoadedJournalEntry._response = parts[2];
            AddJournalEntry(LoadedJournalEntry);

        }
    }
}