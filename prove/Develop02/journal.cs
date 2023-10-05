/*
Name: <journal program>
Purpose: < an application to help users write a journal
by removing excuses not to do it by giving the user a prompt.>
Author: Jason Chandler
Date: (c) 2023
*/
using System;
using System.Net.Http.Headers;
using System.Text.Json;
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
        string JsonString = JsonSerializer.Serialize(this);
        File.WriteAllText(_jcFilename,JsonString);
    }

    public void Load()
    {
        // this method will load the journal from a file
        string text = File.ReadAllText(_jcFilename);
        var jcJournal = JsonSerializer.Deserialize<Journal>(text);

        _jcEntries = jcJournal._jcEntries;
        _jcPrompts = jcJournal._jcPrompts;
    }

    public void DisplayMenu()
    {
        //this meathod displays the menu for the user
        Console.WriteLine("Welcome to the journal program. What would you like to do?");
        Console.WriteLine("Write a new entry.");
        Console.WriteLine("Save journal to file");
        Console.WriteLine("Load journal from file");
        Console.WriteLine("Display Entries");
        Console.WriteLine("Quit");
    }
}