using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

/*
W08 Prove: Developer 
Activity Reflection
Sean Reading, Jason Chandler, Lindsay Hurdman, Kamas Peterson 
(c)2023
*/


class Reflection : Prompt
{
    private List <string> _kpQuestions = new List<string>();

    public Reflection(string kpName, string kpDescription, float kpTime, string kpPrompt, List<string> kpQuestions) : base(kpName, kpDescription, kpTime, kpPrompt)
    {
        _kpQuestions = kpQuestions;
    }

    public void kpDoReflection()
    {
        // Display Start Message 
        jcDisplayStartMessage();
        Console.WriteLine("Get ready...");
        jcAnimation(5);

        // start activity
        Console.WriteLine($"--- {kpGetPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press any button to continue");
        Console.ReadLine();

        // follow up
        DateTime srStart = DateTime.Now; //the time the activity starts
        float srRunTime = 0; //how long the activity has run for already

        Console.WriteLine("Now ponder on each of the following quesions as they realte to this experience.");
        Console.Write("You may begin in:");
        jcCountdown(5);
        Console.Clear();
        while (srRunTime < jcGetTime())
        {    
            Console.WriteLine(kpGetQuesiton());
            jcAnimation(5);
            srRunTime = ((DateTime.Now -srStart).Minutes *60 ) + (DateTime.Now - srStart).Seconds;
        }

        jcDisplayEndMessage();
    }

    private string kpGetQuesiton()
    {
        //returns the questions from the list 
        Random kpRand = new Random();
        string kpRandQuestion = this._kpQuestions[kpRand.Next() % _kpQuestions.Count()];
        return kpRandQuestion;
        // string kpuserentry = Console.ReadLine();
    }
    
}