using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> jcNumbers = new List<int>();
        bool jcSential = false;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            string jcNewStr = Console.ReadLine();
            int jcNewNum = int.Parse(jcNewStr);
            if (jcNewNum != 0)
            {
                jcNumbers.Add(jcNewNum);
            }
        } while (!jcSential);
    }
}