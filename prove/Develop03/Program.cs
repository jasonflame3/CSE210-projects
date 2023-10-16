using System;

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
        bool jcDone = true;
        do
        {
            jcScripture.srDisplay();
            Console.WriteLine();
        } while (jcDone == false);
    }
}