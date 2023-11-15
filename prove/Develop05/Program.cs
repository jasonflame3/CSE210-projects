using System;
using System.IO;
using System.Net.Http.Headers;

/*
W09 Prove: Developer 
Title
Sean Reading, Jason Chandler, Lindsay Hurdman, Kamas Peterson 
11/13/2023
*/

class Program
{
    static void Main(string[] args)
    {
        List<Goal> lhGoals = new();

        //int lhTotalScore = 0;

        string GetFileName()
        {
            // Get file name from the user.
            Console.WriteLine("What is the file name?");
            string lhFileName = Console.ReadLine();
            return lhFileName;
        }

        int GetUserInput(int maxValue)
        {
            int val = int.Parse(Console.ReadLine());
            // If val is between 1 and the maxValue
            if (1 <= val && val <= maxValue)
            {
                return val;
            }
            // If val is outside of range then call method again.
            else
            {
                return GetUserInput(maxValue);
            }
        }

        void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quite");
            Console.WriteLine("Pick an option from the menu");
        }

        void CreateNewGoal()
        {
            Console.WriteLine("The Types of Goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist");
            Console.WriteLine("Pick a type of Goal.");
            int lhAnotherChoice = GetUserInput(3);
            Console.WriteLine("Name of Goal:");
            string lhNameOfGoal = Console.ReadLine();
            Console.WriteLine("Description of Goal");
            string lhDescription = Console.ReadLine();
            Console.WriteLine("Number of Points");
            string lhUserInputPoints = Console.ReadLine();
            int lhPoints = int.Parse(lhUserInputPoints);
            switch(lhAnotherChoice)
            {
                case 1:
                    // Simple goals.
                    Simple simple = new(lhNameOfGoal, lhDescription, lhPoints, false);
                    break;
                case 2:
                    // Eternal goals.
                    srEternal eternal = new("Eternal Goal", lhDescription, lhPoints);
                    break;
                case 3:
                    // Checklist goals.
                    Console.WriteLine("How many times do you want to complete this? ");
                    string lhUserInputFinish = Console.ReadLine();
                    int lhFinish = int.Parse(lhUserInputFinish);
                    Console.WriteLine("How many bonus points?");
                    string lhUserInputBonusPoints = Console.ReadLine();
                    int lhBonusPoints = int.Parse(lhUserInputBonusPoints);
                    Cheacklist checklist = new(lhNameOfGoal, lhDescription, lhPoints, false, 0, lhFinish, lhBonusPoints);
                    break;
            }
        }

        static void DisplayGoals()
        {

        }

        void Save(string lhSaveFileName)
        {
            using (StreamWriter outputFile = new(lhSaveFileName))
            {
                foreach(Goal goal in lhGoals)
                {
                    outputFile.WriteLine($"{goal}");
                }
            }
        }

        static void Load(string lhLoadFileName)
     {
        try
        {
            string[] lines = File.ReadAllLines(lhLoadFileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~~");
            }
            Console.WriteLine("load in file...\n");
        }
        // If the file is not found.
        catch (FileNotFoundException)
        {
            Console.WriteLine($"{lhLoadFileName} was not found \n");
        }
    }

        void Report()
        {
            DisplayGoals();
            Console.WriteLine("Which goal would you like to check off? ");
            GetUserInput(8);
            
        }

        bool lhDone = false;

        while (!lhDone)
        {
            DisplayMenu();
            int lhChoice = GetUserInput(6);
            switch (lhChoice)
            {
                case 1:
                    // Create New Goal.
                    CreateNewGoal();

                    break;

                case 2:
                    // Display Goals.
                    DisplayGoals();
                    break;

                case 3:
                    // Save Goals.
                    string lhSaveFileName = GetFileName();
                    Save(lhSaveFileName);
                    break;

                case 4:
                    // Load Goals.
                    string lhLoadFileName = GetFileName();
                    Load(lhLoadFileName);
                    break;

                case 5:
                    // Record Events.
                    Report();
                    break;

                case 6:
                    // Quite.
                    lhDone = true;
                    break;
            }
        }
    }
}