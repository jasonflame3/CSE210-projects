using System;

/*
W10 Prove: Developer 
The class is for simple everyday goals that can checked off right away. 
Kamas Peterson, Jason Chandler, Sean Reading, Lindsay Hurdman 
(c) 2023 
*/

class Simple : Goal 
{
    public Simple (string kpName, string kpDescription, int kpPoints, bool kpFinished) : base (kpName, "Simple", kpDescription, kpPoints, kpFinished)
    {
        // there are no specific constrictors for this class.
    }
    public override bool kpFinished ()
    {
        // return the kpFinished function.
        return kpGetFinished(); 

    }

    public override int kpReturnPoints()
    {
        // returns the points they have.
        return kpGetPoints();
    }

    public override string kpDisplayGoal()
    {
        // If the user completes their goal it will display that it is checked off.
        // Else it will returns that the users goal is not checked off.
        if (kpFinished())
        {
            return $"[x] {kpGetName()} ({kpGetDescription()}) "; 
        }
        else 
        {
            return $"[ ] {kpGetName()} ({kpGetDescription()})"; 
        }
    }

    public override void kpReport()
    {
      // seting reports whether the user is finished.
      jcSetFinished(true);   
    }

}