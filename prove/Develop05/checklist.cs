class Cheacklist : Goal
{
private int _jcCount;
private int _jcFinish;
private int _jcBonusPoints;

public Cheacklist(string jcName, string jcTypeGoal,string jcDescription, int jcPoints, bool jcFinished,
 int jcCount, int jcFinish, int jcBonusPoints) : base(jcName,jcTypeGoal,jcDescription,jcPoints,jcFinished){
    _jcCount = jcCount;
    _jcFinish = jcFinish;
    _jcBonusPoints = jcBonusPoints;
 }

    public override bool kpFinished(){
        // checks if the goal is done.
        return false;
    }
    public override void kpReport()
    {
        // this is updates the goal everytime it gets completed
        Console.WriteLine("this is not done yet");
    }
    public override string kpDisplayGoal()
    {
        // this will return the goal as a string 
        return "this isn't done yet";
    }
    public override int kpReturnPoints()
    {
        // this calculates how many points one gets if they complete the goal. 
        Console.WriteLine("this is not done yet");
        return 0;
    }
}