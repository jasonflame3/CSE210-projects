using System;

/*
W08 Prove: Developer 
Activity Reflection
Lindsay Hurdman, Kamas Peterson 
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

        // Display End Message 
        jcDisplayEndMessage();

        // Time display 
        jcAnimation(); 

        jcPause();

        // Gets the prompt from the class Prompt
        kpGetPrompt();

        kpGetQuesiton();
    }

    private string kpGetQuesiton()
    {
        //returns the questions from the list 
        Random kpRanQuestion = new Random;
        kpRanQuestion = kpQuestions;
    }
}