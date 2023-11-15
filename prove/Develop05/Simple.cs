using System;

class Simple : Goal 
{
    public Simple (string kpName, string kptypeGoal, string kpDescription, int kpPoints, bool kpFinished) : base (kpName, kptypeGoal, kpDescription, kpPoints, kpFinished)
    {


    }
    public override string kpFinished ()
    {
        kpuserInput = ""; 

        if (kpuserInput != true)
        {
            kpuserInput = false; 
        }

    }

    public override int kpReturnPoints ()
    {

    }

    public override string kpDisplayGoal()
    {
        Console.WriteLine($"{kpName}'s goal is to {}" )
    }

    public override void kpReport()
    {
        
    }

}