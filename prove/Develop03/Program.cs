using System;
using System.Runtime.CompilerServices;
/*
W06 Prove: Developer 
Purpose: Create a prgram to help the user memorize scriptures by slowly hidding words
Name:  Jason Chandler, Kamas Peterson, Lindsay Hurdman, Sean Reading
(c) 2023
*/
class Program
{
    static srScripture jcGetScripture()
    {
        // get the reference and the verse
        Console.Write("What is the reference? ");
        string jcRef = Console.ReadLine();
        Console.Write("what is the scripture you are trying to memorize?");
        string jcWords = Console.ReadLine();
        
        srScripture jcScripture = new srScripture(jcWords,jcRef);
        return jcScripture;
    }

    static void Main(string[] args)
    {
        srScripture jcScripture = jcGetScripture();
        bool jcDone = false;
        do
        {
            Console.Clear();
            Console.WriteLine(jcScripture.srDisplay());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or Q to quit:");
            string jcChoice = Console.ReadLine();
            if (jcChoice == "")
            {
                if (jcScripture.srIsDone() == true)
                {
                    jcDone = true;
                }
                else
                {
                    jcScripture.srUpdate();
                }
            }
            else if (jcChoice.ToLower() == "q")
            {
                jcDone = true;
            }
            
        } while (jcDone == false);
    }
}