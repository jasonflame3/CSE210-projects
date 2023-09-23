using System;

class Program
{
    static void Main(string[] args)
    {
        //Display the message, "welcome to the program"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }

        //Asks for and returns the user's name as as string
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string jcUserName = Console.ReadLine(); 
            return jcUserName; 
        }
        
        //asks for a returns the user's favorite number as an integer
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string jcFavStr = Console.ReadLine();
            int jcFavNum = int.Parse(jcFavStr); 
            return jcFavNum; 
        }

        //Accepts an integer as a parameter and returns that number squared as an integer
        static int SquareNumber(int jcNum)
        {
            int jcSquare = jcNum *jcNum;
            return jcSquare;
        }

        //Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string jcUserName, int jcSquare)
        {
            Console.WriteLine($"{jcUserName}, the square of you number is {jcSquare}");
        }

        DisplayWelcome();
        string jcUserName = PromptUserName();
        int jcUserNumber = PromptUserNumber();
        DisplayResult(jcUserName, SquareNumber(jcUserNumber));
    }
}