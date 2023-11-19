using System.Diagnostics;
using System.Reflection;

/*
W10 Prove : Developer 
Check list 
Jason Chandler, Sean Reading, Lindsay Hurdman, Kamas Peterson 
(c) 2023
*/

class Checklist : Goal
{
private int _jcCount;
private int _jcFinish;
private int _jcBonusPoints;

public Checklist(string jcName,string jcDescription, int jcPoints, bool jcFinished,
 int jcCount, int jcFinish, int jcBonusPoints) : base(jcName,"Checklist",jcDescription,jcPoints,jcFinished){
    _jcCount = jcCount;
    _jcFinish = jcFinish;
    _jcBonusPoints = jcBonusPoints;
 }

    public override bool kpFinished(){
        // checks if the goal is done.
        Debug.Assert(_jcCount <= _jcFinish);
        if((_jcCount == _jcFinish) && kpGetFinished()){
            return true;
        }
        else{
        return false;
        }
    }
    public override void kpReport()
    {
        // this is updates the goal everytime it gets completed
        Debug.Assert(kpGetFinished() == false);
        _jcCount += 1;
        if (_jcCount == _jcFinish){
            jcSetFinished(true);
        }
    }
    public override string kpDisplayGoal()
    {
        // this will return the goal as a string 

        if (kpGetFinished()){
            return $"[x] {kpGetName()} ({kpGetDescription()}) -- {_jcCount}/{_jcFinish}";
        }
        else{
            return $"[ ] {kpGetName()} ({kpGetDescription()}) -- {_jcCount}/{_jcFinish}";
        }
        
    }
    public override int jcGetCount(){
        return _jcCount;
    }

    public override int jcGetBonusPoints(){
        return _jcBonusPoints;
    }
    public override int jcFinish(){
        return _jcFinish;
    }
    public override int kpReturnPoints()
    {
        // this calculates how many points one gets if they complete the goal. 
        int tally = 0;
        Debug.Assert(_jcCount <= _jcFinish);

        if (_jcCount == _jcFinish){
            tally += _jcBonusPoints + kpGetPoints() * _jcCount - 1;
        }
        else{
            tally += kpGetPoints();
        }

        return tally;
    }
}