using System;
/*
W08 Prove: Developer 
Provied each activity with a random prompt
Lindsay Herdman, Kamas Peterson 
(c)2023
*/

class Prompt : Activity
{
    private string _kpPrompt;

    public Prompt(string kpName, string kpDecription, float kpTime, string kpPrompt) : base(kpName, kpDecription, kpTime)
    {
        kpPrompt = _kpPrompt; 
    }
    
    protected string kpGetPrompt ()
    {
        return _kpPrompt;
    }
   
}