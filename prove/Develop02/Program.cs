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

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal._jcPrompts.Add("");

        int jcSential = 0;
        int jcChoice = 0;
        do 
        {
            journal.DisplayMenu();
            do {
                Console.Write("What would you like to do? ");
                try{
                jcChoice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                Console.WriteLine("Your input must be an integer between 1 and 5");
                } 
            
            } while ((jcChoice < 6) & (jcChoice > 0));

            switch (jcChoice)
            {
                case 1:
                    //Write a new entry
                    journal.WriteEntry();
                    break;
                case 2:
                    // save to a file
                    Console.Write("What is the file name? ");
                    journal._jcFilename = Console.ReadLine();

                    journal.Save();
                    break;
                case 3:
                    //load from a file
                    break;
                case 4:
                    //display entries
                    break;
                case 5:
                    // quit
                    jcSential = 1;
                    break;
            }

        } while (jcSential == 0);
        
    }
}

/*
https://stackoverflow.com/questions/13297563/read-and-parse-a-json-file-in-c-s
https://www.educative.io/answers/how-to-read-a-json-file-in-c-sharp
https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-8-0
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this
https://www.educative.io/answers/how-to-generate-a-random-integer-in-c-sharp
https://www.w3schools.com/cs/cs_switch.php
*/