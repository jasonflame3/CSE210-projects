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
            Console.WriteLine("What is the file name?");
            string lhFileName = Console.ReadLine();
            return lhFileName;
        }

        int GetUserInput(int maxValue)
        {
            Console.Write("Select a choice from the menu ");
            int val = int.Parse(Console.ReadLine());
            // if val is between 1 and 6
            if (1 <= val && val <= maxValue){
                return val;
            }
            else{
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
        }

        void CreateNewGoal()
        {
            Console.WriteLine("The Types of Goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist");
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
        try{
            string[] lines = File.ReadAllLines(lhLoadFileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~~");
            }
            Console.WriteLine("load in file...\n");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Your file was not found \n");
        }
    }

        static void Report()
        {

        }

        bool lhDone = false;

        while (!lhDone)
        {
            DisplayMenu();
            int lhChoice = GetUserInput(6);
            switch (lhChoice)
            {
                case 1:
                    // Create New Goal
                    CreateNewGoal();
                    int lhAnotherChoice = GetUserInput(3);
                    switch(lhAnotherChoice)
                    {
                        case 1:
                            // simple goals
                            Simple simple = new("Simple Goal", "Simple", "description", 0, false);
                            break;
                        case 2:
                            // eternal goals
                            srEternal eternal = new("Eternal Goal", "description", 0);
                            break;
                        case 3:
                            // checklist goals
                            Cheacklist checklist = new("Checklist Goal", "Checklist", "description", 0, false, 0, 0, 0);
                            break;
                    }
                    break;

                case 2:
                    // Display Goals
                    DisplayGoals();
                    break;

                case 3:
                    // Save Goals
                    string lhSaveFileName = GetFileName();
                    Save(lhSaveFileName);
                    break;

                case 4:
                    // Load Goals
                    string lhLoadFileName = GetFileName();
                    Load(lhLoadFileName);
                    break;

                case 5:
                    // Record Events
                    Report();
                    break;

                case 6:
                    // Quite
                    lhDone = true;
                    break;
            }
        }
    }
}