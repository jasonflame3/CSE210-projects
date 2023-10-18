using System;
using System.Runtime.CompilerServices;

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
            jcScripture.srDisplay();
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