using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

/*
W10 Prove: Developer
This programs purpose is to help the user to set goals whether they are simple, eternal, or complex
Kamas Peterson, Jason Chandler, Sean Reading, Lindsay Hurdman 
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

    public string kpGetName ()
    {
        // returns kpName so that all the other classes can use it.
        return _kpName;
    }
    protected string kpGettypeGoal ()
    {
        // returns kptypeGoal so that all other classes can use it.
        return _kptypeGoal;
    }
    public string kpGetDescription ()
    {
        // returns kpDescription so that all other classes can use it.
        return _kpDescription;
    }
    public int kpGetPoints ()
    {
        // returns kpPoints so that all other classes can use it. 
        return _kpPoints;
    }
    public bool kpGetFinished ()
    {
        //returns kpFinished so that all other classes can use it.
        return _kpFinished;
    }
    
    public virtual int jcGetCount(){
        Debug.Assert(false);
        return 0;
    }

    public virtual int jcGetBonusPoints(){
        Debug.Assert(false);
        return 0;
    }

    public virtual int jcFinish()
    {
        Debug.Assert(false);
        return 0;
    }
    protected void jcSetFinished (bool jcFinish)
    {
        // Allows child class to set the finished. 
        _kpFinished = jcFinish;
    }

}