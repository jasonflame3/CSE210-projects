using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?");
        string jcMagicNumStr = Console.ReadLine();
        int jcMagicNumInt = int.Parse(jcMagicNumStr);

        bool jcFound = false;
        do         {
            Console.Write("what is your first guess?");
            string jcGuessStr = Console.ReadLine();
            int jcGuessInt = int.Parse(jcGuessStr);
            if (jcGuessInt < jcMagicNumInt)
            {
                Console.WriteLine("Higher");
            }
            else if (jcGuessInt > jcMagicNumInt)
            {
                Console.WriteLine("Lower");
            }
            else if (jcGuessInt == jcMagicNumInt)
            {
                Console.WriteLine("Youe guessed my number!");
                jcFound = true;
            }
        } while (! jcFound);
    }
}