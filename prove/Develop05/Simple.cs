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

    }

    public override string kpDisplayGoal()
    {
        if (kpFinished())
        {
            return $"[x] {kpDescription} "; 
        }
        return 
    }

    public override void kpReport()
    {
      jcSetFinished(true);   
    }

}