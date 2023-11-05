using System;
using System.Diagnostics;
using System.Reflection;

/*
W08 Prove: Developer 
Breathing Activity
Sean Reading, Jason Chandler, Lindsay Hurdman, Kamas Peterson 
11/1/2023
*/

class Program
{
    static void Main(string[] args)
    {
        string jcBreathingDiscription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string jcReflectionDiscription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string jcListingDecription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        List<string> jcQuestions = new List<string>()
                        {
                            "Why was this experience meaningful to you?",
                            "Have you ever done anything like this before?",
                            "How did you get started?",
                            "How did you feel when it was complete?",
                            "What made this time different than other times when you were not as successful?",
                            "What is your favorite thing about this experience?",
                            "What could you learn from this experience that applies to other situations?",
                            "What did you learn about yourself through this experience?",
                            "How can you keep this experience in mind in the future?",
                        };

        void jcDisplayMenu(){
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        }

        string jcGetPrompt(string type){
            Random jcRand = new Random();
            string jcRandPrompt;
            List<string> jcReflectionPrompts = new List<string>()
                        {
                          "Think of a time when you stood up for someone else.",
                          "Think of a time when you did something really difficult.",
                          "Think of a time when you helped someone in need.",
                          "Think of a time when you did something truly selfless."
                        };
            List<string> jcListingPrompts = new List<string>()
                        {
                          "Who are people that you appreciate?",
                          "What are personal strengths of yours?",
                          "Who are people that you have helped this week?",
                          "When have you felt the Holy Ghost this month?",
                          "Who are some of your personal heroes?",
                        };
            if (type.ToUpper() == "R"){
                jcRandPrompt = jcReflectionPrompts[jcRand.Next() % jcReflectionPrompts.Count()];
            }
            else if (type.ToUpper() == "L"){
                jcRandPrompt = jcListingPrompts[jcRand.Next() % jcListingPrompts.Count()];
            }
            else {
                Debug.Assert(false,"this function was called wrong");
                jcRandPrompt = "";
            }
            return jcRandPrompt;
        }


        int jcGetUserInput(){
            Console.Write("Select a choice from the menu ");
            int val = int.Parse(Console.ReadLine());
            // if val is between 1 and 4
            if (1 <= val && val <= 4){
                return val;
            }
            else{
                return jcGetUserInput();
            }
        }

        bool done = false;

        while (!done){
            jcDisplayMenu();
            int choice = jcGetUserInput();

            switch (choice){
                case 1:
                    Breathing breathing = new Breathing("breathing",jcBreathingDiscription,0);
                    breathing.srDoBreathing();
                    break;
                case 2:
                    Reflection reflection = new Reflection("reflection",jcReflectionDiscription,0,jcGetPrompt("R"),jcQuestions);
                    reflection.kpDoReflection();
                    break;
                case 3:
                    Listing listing = new Listing("listing",jcListingDecription,0,jcGetPrompt("L"));
                    listing.LhDoListing();
                    break;
                case 4:
                    done = true;
                    break;
            }
        }

    }
}
// reference https://www.tutorialsteacher.com/csharp/csharp-list
// https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.debug.assert?view=net-7.0
// https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-7.0
