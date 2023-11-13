using System;

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
        List<Goal> lhGoals = new List<Goal>();

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

        static void Save(string lhSaveFileName)
        {

        }

        static void Load(string lhLoadFileName)
        {

        }

        static void Report()
        {

        }

        bool done = false;

        while (!done)
        {
            DisplayMenu();
            int choice = GetUserInput(6);
            switch (choice){
                case 1:
                    CreateNewGoal();
                    int anotherChoice = GetUserInput(4);
                    break;
                case 2:
                    DisplayGoals();
                    break;
                case 3:
                    string lhSaveFileName = GetFileName();
                    Save(lhSaveFileName);
                    break;
                case 4:
                    string lhLoadFileName = GetFileName();
                    Load(lhLoadFileName);
                    break;
                case 5:
                    Report();
                    break;
                case 6:
                    done = true;
                    break;

            }
        }
   

    }


}