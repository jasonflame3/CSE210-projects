using System;

/*
W08 Prove: Developer 
Provied each activity with a random prompt
Lindsay Hurdman, Kamas Peterson 
(c)2023
*/

class Prompt : Activity
{
    private readonly string _kpPrompt;
    public Prompt(string kpName, string kpDescription, float kpTime, string kpPrompt) : base(kpName, kpDescription, kpTime)
    {
        _kpPrompt = kpPrompt; 
    }
    
    protected string KpGetPrompt ()
    {
        return _kpPrompt;
    }
   
}