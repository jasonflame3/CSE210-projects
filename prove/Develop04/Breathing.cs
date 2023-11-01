using System;

class Breathing : Activity
{

    //Constructors
    public Breathing(string srName, string srDescription, float srTime) : base(srName, srDescription, srTime)
    {

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




        
    }

}