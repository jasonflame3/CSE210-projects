using System;

class Breathing : Activity
{

    //Constructors
    public Breathing(string srName, string srDescription, float srTime) : base(srName, srDescription, srTime)
    {
        //Breathing doesn't have its own attributes, so there isn't anything in this part of the constructor
    }

    //returns a message that is printed by DoBreathing
    private string srDisplayMessage(bool srInhaling)
    {
        string srDirection = "out";
        if (srInhaling) {srDirection = "in";} //changes the message if you are inhaling or exhaling

        return "Breathe " + srDirection + "...";
    }

    public void srDoBreathing()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...\n");

        float srRunTime = 0; //how long the activity has run for already
        while (srRunTime < _srTime)
        {
            
        }
    }

}