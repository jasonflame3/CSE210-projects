/*
Name: <journal program>
Purpose: < an application to help users write a journal
by removing excuses not to do it by giving the user a prompt.>
Author: Jason Chandler
Date: (c) 2023
*/
using System;
using System.IO;
using System.Net.Http.Headers;
public class Journal
{
    public Journal()
    {}
    
    public List<Entry> _jcEntries = new List<Entry>();
    public List<string> _jcPrompts = new List<string>();
    public string _jcFilename;

    public void Display()
    {
        // will iterate through each entry and display the date, prompt, and response(words).
        foreach(Entry entry in _jcEntries)
        {
            Console.WriteLine($"Date:{entry._jcDate} - Prompt: {entry._jcPrompt}");
            Console.WriteLine(entry._jcWords);
            Console.WriteLine("");
        }
    }

    public void WriteEntry()
    {
        // this method will allow the user to write new entries.
        Entry jcCurrentEntry = new Entry();
        
        // Get the date
        DateTime theCurrentTime = DateTime.Now;
        jcCurrentEntry._jcDate = theCurrentTime.ToShortDateString();
        
        // Get the prompt and display it
        System.Random random = new System.Random();
        int jcPromptIndex = random.Next(5);
        jcCurrentEntry._jcPrompt = _jcPrompts[jcPromptIndex];
        Console.WriteLine(jcCurrentEntry._jcPrompt);
        
        // Get the users response
        jcCurrentEntry._jcWords = Console.ReadLine();

        // Add the current entry to the list
        _jcEntries.Add(jcCurrentEntry);

        // Datetime syntax from the code helps section of the assignment
    }

    public void Save()
    {
        // this method will save the entries to a file.

        using (StreamWriter outputFile = new StreamWriter(_jcFilename))
        {
            foreach(Entry entry in _jcEntries)
            {
                outputFile.WriteLine($"{entry._jcDate}~~{entry._jcPrompt}~~{entry._jcWords}");
            }
        }
    }

    public void Load()
    {
        // this method will load the journal from a file
        try{
            string[] lines = File.ReadAllLines(_jcFilename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~~");
                Entry jcCurrent = new Entry
                {
                    _jcDate = parts[0],
                    _jcPrompt = parts[1],
                    _jcWords = parts[2]
                };
                _jcEntries.Add(jcCurrent);
            }
            Console.WriteLine("load in file...\n");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Your file was not found \n");
        }
    }

    public void DisplayMenu()
    {
        //this meathod displays the menu for the user
        Console.WriteLine("Welcome to the journal program. What would you like to do?");
        Console.WriteLine("1: Write a new entry.");
        Console.WriteLine("2: Save journal to file");
        Console.WriteLine("3: Load journal from file");
        Console.WriteLine("4: Display Entries");
        Console.WriteLine("5: Quit");
    }
}