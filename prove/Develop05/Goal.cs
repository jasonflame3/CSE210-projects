using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

/*
W10 Prove: Developer
This programs purpose is to help the user to set goals whether they are simple, eternal, or complex
Kamas Peterson 
(c) 2023
*/

abstract class Goal 
{
    private string _kpName; 
    private string _kptypeGoal; 
    private string _kpDescription; 
    private int _kpPoints; 
    private bool _kpFinished; 

    protected Goal (string kpName, string kptypeGoal, string kpDescription, int kpPoints, bool kpFinished)
    {
        _kpName = kpName;
        _kptypeGoal = kptypeGoal;
        _kpDescription = kpDescription; 
        _kpPoints = kpPoints;
        _kpFinished = kpFinished; 
    }

    public abstract bool kpFinished ();
    // When the user has completed their goal
    

    public abstract string kpDisplayGoal ();
   // Displays the users goal or goals

    public  abstract int kpReturnPoints ();
    //returns the point for the goal that has been completed

    public abstract void kpReport ();
    // Reports how many points the user has.

    protected string kpGetName ()
    {
        return _kpName;
    }
    protected string kpGettypeGoal ()
    {
        return _kptypeGoal;
    }
    protected string kpGetDescription ()
    {
        return _kpDescription;
    }
    protected int kpGetPoints ()
    {
        return _kpPoints;
    }
    protected bool kpGetFinished ()
    {
        return _kpFinished;
    }
    
}