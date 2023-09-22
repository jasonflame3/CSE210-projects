using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Grade: ");
        string jcGradeNumStr = Console.ReadLine();
        int jcGradeNumint = int.Parse(jcGradeNumStr);
        string jcLetterGrade;

        if ( jcGradeNumint >= 90 ){
            jcLetterGrade = "A";
            // Console.WriteLine("Your grade is an A");
        }
        else if ( jcGradeNumint >= 80 ){
            jcLetterGrade = "B";
            // Console.WriteLine("Your grade is an B");
        }
        else if ( jcGradeNumint >= 70 ){
            jcLetterGrade = "C";
            // Console.WriteLine("Your grade is an C");
        }
        else if ( jcGradeNumint >= 60 ){
            jcLetterGrade = "D";
            // Console.WriteLine("Your grade is an D");
        }
        else {
            jcLetterGrade = "F";
            // Console.WriteLine("Your grade is an F");
        }

        Console.WriteLine($"Your letter grade is {jcLetterGrade}");
        if (jcGradeNumint >= 70){
            Console.WriteLine("Congrats on passing the class");
        }
        else
        {
            Console.WriteLine("Better Luck next time");
        }

    }
}