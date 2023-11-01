using System;
using System.Reflection;

class Activity
{
    private string _srName;
    private string _srDescription;
    private float _srTime;



public Activity(string jcName, string jcDecription, float jcTime)
{
    _srName = jcName;
    _srDescription = jcDecription;
    _srTime =jcTime;
}

public void jcAnimation(){
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

public void jcPause(){
// jcTime is measured in seconds
int jcMilliseconds = (int)(_srTime * 1000);
Thread.Sleep(jcMilliseconds);
}
protected void jcCountdown(){



}








}