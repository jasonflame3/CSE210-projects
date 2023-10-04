/*
This is the class for journal
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

    }

    public void WriteEntry()
    {
        // this method will allow the user to write new entries.
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

    public void quit()
    {

    }
}