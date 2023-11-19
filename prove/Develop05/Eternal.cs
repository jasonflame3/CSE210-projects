using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.XPath;

/*
W010 Prove: Developer 
Eternal Goal
Sean Reading, Jason Chandler, Lindsay Hurdman, Kamas Peterson 
11/13/2023
*/

class srEternal : Goal
{
    private int _count;
    //constructors
    public srEternal(string name, string description, int points, int count) : base(name, "Eternal", description, points, false) {
    _count = count;
    }

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
        return $"[ ] " + kpGetName() + " (" + kpGetDescription() + ") -- " + jcGetCount() + " times!";
    }

    //this does something
    public override void kpReport()
    {
        _count += 1;
    }

    public override int jcGetCount()
    {
        return _count;
    }
}