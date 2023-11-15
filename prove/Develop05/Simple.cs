using System;

/*
W10 Prove: Developer 
The class is for simple everyday goals that can checked off right away. 
Kamas Peterson, Jason 
(c) 2023 
*/

class Simple : Goal 
{
    public Simple (string kpName, string kpDescription, int kpPoints, bool kpFinished) : base (kpName, "Simple", kpDescription, kpPoints, kpFinished)
    {


    }
    public override bool kpFinished ()
    {
        return kpGetFinished(); 

    }

    public override int kpReturnPoints()
    {
        return kpGetPoints();
    }

    public override string kpDisplayGoal()
    {
        if (kpFinished())
        {
            return $"[x] {kpGetName()} ({kpGetDescription()}) "; 
        }
        else 
        {
            return $"[ ] {kpGetName()} ({kpGetDescription()}"; 
        }
    }

    public override void kpReport()
    {
      jcSetFinished(true);   
    }

}