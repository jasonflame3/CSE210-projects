using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._company = "Lenovo";
        job2._jobTitle = "Laptop Repair Technician";
        job2._startYear = 2018;
        job2._endYear = 2020;

        Console.WriteLine(job2._company);
            }
}