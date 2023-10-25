using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("jason chandler", "computer science");
        Console.WriteLine(assignment.jcGetSummery());

        MathAssignment mathAssignment = new MathAssignment("7.3","8-19","Jason Chandler","Fractions");
        Console.WriteLine(mathAssignment.jcGetSummery());
        Console.WriteLine(mathAssignment.jcGetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "Europian History", "The causes of World War II");
        Console.WriteLine(writingAssignment.jcGetSummery());
        Console.WriteLine(writingAssignment.jcGetWritingInformation());
    }
}