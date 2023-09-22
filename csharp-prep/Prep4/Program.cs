using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> jcNumbers = new List<int>();
        bool jcSential = false;

        // get the lsit of numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter Number: ");
            string jcNewStr = Console.ReadLine();
            int jcNewNum = int.Parse(jcNewStr);
            if (jcNewNum != 0)
            {
                jcNumbers.Add(jcNewNum);
            }
            else
            {
                jcSential = true;
            }
        } while (!jcSential);

        // Find the sum
        int jcSum = 0;
        foreach (int jcNum in jcNumbers)
        {
            jcSum += jcNum;
        }
        Console.WriteLine($"The sum is: {jcSum}");

        // Compute the average
        float jcAverage = (jcSum / jcNumbers.Count);
        Console.WriteLine($"The average is: {jcAverage}");
    }
}