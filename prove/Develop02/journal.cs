/*
This is the class for journal
*/

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