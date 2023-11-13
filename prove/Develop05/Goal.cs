using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

/*
W10 Prove: Developer

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

    public abstract bool Finished ();
    

    public abstract string DisplayGoal ();
   

    public  abstract int ReturnPoints ();

    public abstract void Report ();

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