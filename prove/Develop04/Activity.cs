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
    int srTimes = 3; //Change this to increase or decrease the duration of the animation
    string srBack = "\b \b"; //the backspace character

    Console.WriteLine(""); //create a space for the animation to happen in

    for (int x = 1; x <= srTimes; x++) //do the animation
    {
    Console.Write(srBack + "-");
    Console.Write(srBack + "\\");
    Console.Write(srBack + "|");
    Console.Write(srBack + "/");
    }

    Console.WriteLine(""); //end the space for the animation
}

protected void jcDisplayStartMessage(){



}

protected void jcDisplayEndMessage(){



}

protected void jcPause(float jcTime){



}
protected void jcCountdown(){



}








}