using System;
using System.Reflection;

class Activity
{
private string srName;
    private string srDescription;
    private float srTime;



public Activity(string jcName, string jcDecription, float jcTime)
{
    srName = jcName;
    srDescription = jcDecription;
    srTime =jcTime;
}

protected void jcAnimation(){



}

protected void jcDisplayStartMessage(){



}

protected void jcDisplayEndMessage(){



}

protected void jcPause(float jcTime){
// jcTime is measured in seconds
int jcMilliseconds = (int)(jcTime * 1000);
Thread.Sleep(jcMilliseconds);
}
protected void jcCountdown(){



}








}