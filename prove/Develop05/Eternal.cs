using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

/*
W010 Prove: Developer 
Eternal Goal
Sean Reading
11/13/2023
*/

class srEternal : Goal
{
    //constructors
    public srEternal(string name, string description, int points) : base(name, "eternal", description, points, false) {}

    //this is the goal that never ends; and it goes on and on my friends...
    public override bool kpFinished()
    {
        return false;
    }

    //return the number of points this goal is worth
    public override int kpReturnPoints()
    {
        return kpGetPoints();
    }

    //return a string containing the name and description of the goal
    public override string kpDisplayGoal()
    {
        return "[ ]" + kpGetName() + " (" + kpGetDescription() + ")";
    }

    //this does something
    public override void kpReport()
    {
        
    }
}