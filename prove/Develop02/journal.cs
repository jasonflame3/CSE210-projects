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

    public void writeEntry()
    {

    }

    public void save()
    {

    }

    public void load()
    {
        string text = File.ReadAllText(_jcFilename);
    }

    public void DisplayMenu()
    {
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