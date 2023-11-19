using System;
using System.ComponentModel;
using System.IO;

/*
W09 Prove: Developer 
Title
Lindsay Hurdman, Sean Reading, Jason Chandler, Kamas Peterson 
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
            int val;
            while (!int.TryParse(Console.ReadLine(), out val) || val < 1 || val > maxValue)
            {
                Console.Write($"Please enter a valid input between 1 and {maxValue}: ");
            }

            return val;
        }


        void DisplayMenu()
        // DONE!
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");
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
                    srEternal eternal = new(lhNameOfGoal, lhDescription, lhPoints, 0);
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

                    Checklist checklist = new(lhNameOfGoal, lhDescription, lhPoints, false, 0, lhFinish, lhBonusPoints);
                    lhGoals.Add(checklist);
                    break;
            }
        }

        void DisplayGoals()
        // DONE!
        {
            Console.WriteLine("\nList of Goals: ");
            int count = 1;
            int points = 0;
            foreach (Goal goal in lhGoals)
            {
                string countString = count.ToString();
                Console.WriteLine($"{countString}: {goal.kpDisplayGoal()}");
                // Console.WriteLine(goal.kpDisplayGoal());
                count += 1;
                if (goal.kpFinished())
                {
                    points += goal.kpReturnPoints();
                }
                else if (goal.GetType().Name == "Checklist")
                {
                    if (goal.jcGetCount() > 0)
                    {
                        points += goal.kpReturnPoints() * goal.jcGetCount();
                    }
                }
                else if (goal.GetType().Name == "srEternal")
                {
                    if (goal.jcGetCount() > 0)
                    {
                        points += goal.kpReturnPoints() * goal.jcGetCount();
                    }
                }

            }
            Console.WriteLine($"You have {points} points.\n");
        }

        void Save(string lhSaveFileName)
        // DONE!
        {
            try
            {
                using (StreamWriter outputFile = new(lhSaveFileName))
                {
                    foreach (Goal goal in lhGoals)
                    {
                        if (goal.GetType().Name == "Checklist")
                        {
                            outputFile.WriteLine($"{goal.GetType().Name}~~{goal.kpGetName()}~~{goal.kpGetDescription()}~~{goal.kpGetPoints()}~~{goal.kpGetFinished()}~~{goal.jcGetCount()}~~{goal.jcFinish()}~~{goal.jcGetBonusPoints()}");
                        }
                        else if (goal.GetType().Name == "srEternal")
                        {
                            outputFile.WriteLine($"{goal.GetType().Name}~~{goal.kpGetName()}~~{goal.kpGetDescription()}~~{goal.kpGetPoints()}~~{goal.kpGetFinished()}~~{goal.jcGetCount()}");
                        }
                        else
                        {
                            outputFile.WriteLine($"{goal.GetType().Name}~~{goal.kpGetName()}~~{goal.kpGetDescription()}~~{goal.kpGetPoints()}~~{goal.kpGetFinished()}");
                        }
                        // Saved in the format: "Type~~Name~~Description~~Points~~Finished"
                    }
                }

                Console.WriteLine($"Goals saved in {lhSaveFileName}.\n");
                Console.Write("Press Enter to Continue: ");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving goals: {ex.Message}\n");
            }
        }

        void Load(string lhLoadFileName)
        // DONE!
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
                            int _count = int.Parse(parts[5]);
                            loadedGoal = new srEternal(name, description, points, _count);
                            break;
                        case "Checklist":
                            int count = int.Parse(parts[5]);
                            int finish = int.Parse(parts[6]);
                            int bonusPoints = int.Parse(parts[7]);
                            loadedGoal = new Checklist(name, description, points, finished, count, finish, bonusPoints);
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
                Console.Write("Press Enter to Continue: ");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading goals: {ex.Message}\n");
            }
        }

        void Report()
        // DONE!
        {
            bool reportDone = false;
            while (!reportDone)
            {
                DisplayGoals();
                Console.Write("Which goal would you like to check off? ");
                int goalIndex = GetUserInput(lhGoals.Count) - 1;
                Goal selectedGoal = lhGoals[goalIndex];

                selectedGoal.kpReport();

                Console.WriteLine("Event recorded.\n");
                Console.WriteLine("Would you like record another goal? \n1. Yes \n2. No ");
                int reportChoice = GetUserInput(2);
                if (reportChoice == 2)
                {
                    reportDone = true;
                }
            }
                
        }

        // DONE!
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
                    Console.Write("Press Enter to Continue: ");
                    Console.ReadLine();
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
                    // Quit.
                    lhDone = true;
                    break;
            }
        }
    }
}