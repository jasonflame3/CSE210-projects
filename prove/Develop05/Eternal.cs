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
    public srEternal() : base() {}
    public srEternal(string name, string description, int points) : base(name, "eternal", description, points, false) {}

    //I don't know what this is supposed to do here but it's in the plan, so it's here too
    public override void finished()
    {

    }

    //return the number of points this goal is worth
    public override int returnPoints()
    {
        return _kpPoints;
    }

    //return a string containing the name and description of the goal
    public override string displayGoal()
    {
        return "[ ]" + _kpName + "(" + _kpDescription + ")";
    }
}