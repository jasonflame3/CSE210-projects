using System;

/*
W08 Prove: Developer 
Activity Reflection
Lindsay Hurdman, Kamas Peterson 
(c)2023
*/


class Reflection : Prompt
{
    private List <string> _kpQuestions = new List<string>;

    public Reflection(string kpName, string kpDescription, float kpTime, string kpPrompt, List<string> kpQuestions) : base(kpName, kpDescription, kpTime, kpPrompt)
    {
        _kpQuestions = kpQuestions;
    }

    public void kpDoReflection()
    {
        //Displays the Starting Message 
        jcDisplayStartMessage(); 

        //Displays the end Message
        jcDisplayEndMessage();

        // Time display 
        jcAnimation(); 

        jcPause();
    }

    private List<string> kpGetQuesitons()
    {
        //returns the questions from the list 
        return _kpQuestions;
    }
}