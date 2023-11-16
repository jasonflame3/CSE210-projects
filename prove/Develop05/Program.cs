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
        // List that holds the goals.
        List<Goal> lhGoals = new();

        string GetFileName()
        // DONE!
        {
            // Get file name from the user.
            Console.WriteLine("What is the file name?");
            string lhFileName = Console.ReadLine();
            return lhFileName;
        }

        int GetUserInput(int maxValue)
        // DONE!
        {
            int val = int.Parse(Console.ReadLine());
            // If val is between 1 and the maxValue.
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
        // DONE!
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quite");
            Console.Write("Pick an option from the menu: ");
        }

        void CreateNewGoal()
        // DONE!
        {
            Console.WriteLine("\nThe Types of Goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist");
            Console.Write("Pick a type of Goal: ");

            int lhAnotherChoice = GetUserInput(3);

            Console.Write("\nName of Goal: ");
            string lhNameOfGoal = Console.ReadLine();

            Console.Write("Description of Goal: ");
            string lhDescription = Console.ReadLine();

            Console.Write("Number of Points: ");
            string lhUserInputPoints = Console.ReadLine();
            int lhPoints = int.Parse(lhUserInputPoints);

            switch(lhAnotherChoice)
            {
                case 1:
                    // Simple goals.
                    Simple simple = new(lhNameOfGoal, lhDescription, lhPoints, false);
                    lhGoals.Add(simple);
                    break;

                case 2:
                    // Eternal goals.
                    srEternal eternal = new(lhNameOfGoal, lhDescription, lhPoints);
                    lhGoals.Add(eternal);
                    break;
                    
                case 3:
                    // Checklist goals.
                    Console.Write("How many times do you want to complete this? ");
                    string lhUserInputFinish = Console.ReadLine();
                    int lhFinish = int.Parse(lhUserInputFinish);

                    Console.Write("How many bonus points? ");
                    string lhUserInputBonusPoints = Console.ReadLine();
                    int lhBonusPoints = int.Parse(lhUserInputBonusPoints);

                    Cheacklist checklist = new(lhNameOfGoal, lhDescription, lhPoints, false, 0, lhFinish, lhBonusPoints);
                    lhGoals.Add(checklist);
                    break;
            }
        }

        void DisplayGoals()
        // DONE!
        {
            Console.WriteLine("List of Goals: ");
            int count = 1;
            foreach (Goal goal in lhGoals)
            {
                string countString = count.ToString();
                Console.WriteLine(countString);
                Console.WriteLine(goal.kpDisplayGoal());
                count += 1;
            }
        }

        void Save(string lhSaveFileName)
        // Need thing to be accessable first.
        // Besides that finished.
        {
            try
            {
                using (StreamWriter outputFile = new(lhSaveFileName))
                {
                    foreach (Goal goal in lhGoals)
                    {
                        // Saved in the format: "Type~~Name~~Description~~Points~~Finished"
                        outputFile.WriteLine($"{goal.GetType().Name}~~{goal.kpGetName()}~~{goal.kpGetDescription()}~~{goal.kpGetPoints()}~~{goal.kpGetFinished()}");
                    }
                }

                Console.WriteLine($"Goals saved in {lhSaveFileName}.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving goals: {ex.Message}\n");
            }
        }

        void Load(string lhLoadFileName)
        // DONE!
        // Unless things break after Save is fixed.
        {
            try
            {
                // Clear existing goals before loading.
                lhGoals.Clear();

                string[] lines = File.ReadAllLines(lhLoadFileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split("~~");

                    // Parse values from the line.
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool finished = bool.Parse(parts[4]);

                    // Create a new goal based on the type.
                    Goal loadedGoal;
                    switch (type)
                    {
                        case "Simple":
                            loadedGoal = new Simple(name, description, points, finished);
                            break;
                        case "srEternal":
                            loadedGoal = new srEternal(name, description, points);
                            break;
                        case "Cheacklist":
                            int count = int.Parse(parts[5]);
                            int finish = int.Parse(parts[6]);
                            int bonusPoints = int.Parse(parts[7]);
                            loadedGoal = new Cheacklist(name, description, points, finished, count, finish, bonusPoints);
                            break;
                        default:
                            // Shouldn't ever happen, but just in case.
                            Console.WriteLine($"Unknown goal type: {type}");
                            continue;
                    }

                    // Add the loaded goal to the list.
                    lhGoals.Add(loadedGoal);
                }

                Console.WriteLine("Goals loaded successfully.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading goals: {ex.Message}\n");
            }
        }

        void Report()
        // DONE!
        {
            DisplayGoals();
            Console.WriteLine("Which goal would you like to check off? ");
            int goalIndex = GetUserInput(lhGoals.Count) - 1;
            Goal selectedGoal = lhGoals[goalIndex];

            selectedGoal.kpReport();

            Console.WriteLine("Event recorded.\n");
            
        }

        // DONE!
        bool lhDone = false;

        while (!lhDone)
        {
            DisplayMenu();
            int lhChoice = GetUserInput(6);
            Console.WriteLine("Entering loop");
            switch (lhChoice)
            {
                case 1:
                    // Create New Goal.
                    CreateNewGoal();
                    break;

                case 2:
                    // For some reason it is not wanting to go into case 2 so
                    // I put this print statment to see if it does or does not.
                    Console.WriteLine("Entering Case 2");

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