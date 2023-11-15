using System;
using System.Text.Json.Nodes;

class Simple : Goal 
{
    public Simple (string kpName, string kptypeGoal, string kpDescription, int kpPoints, bool kpFinished) : base (kpName, kptypeGoal, kpDescription, kpPoints, kpFinished)
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