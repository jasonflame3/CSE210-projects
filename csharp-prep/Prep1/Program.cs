using System;

class Program
{
    static void Main(string[] args)
    {
        /* simple program to make a spy name */
        Console.Write("What is your first name? ");
        string jcFirstName = Console.ReadLine();
        Console.Write("What is YOur last name? ");
        string jcLastName = Console.ReadLine();
        
        Console.WriteLine("");
        Console.WriteLine($"Your name is {jcLastName}, {jcFirstName} {jcLastName}.");
    }
}