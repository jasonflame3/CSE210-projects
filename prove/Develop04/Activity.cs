using System;
using System.Reflection;
/*
W08 Prove: Developer 
Activity
Sean Reading, Jason Chandler, Lindsay Hurdman, Kamas Peterson 
11/4/2023
*/
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

    public void jcAnimation(int srTimes){
        string srBack = "\b \b"; //the backspace character

        Console.WriteLine(""); //create a space for the animation to happen in

        for (int x = 1; x <= srTimes; x++) //do the animation
        {
            Console.Write(srBack + "-");
            Thread.Sleep(250);
            Console.Write(srBack + "\\");
            Thread.Sleep(250);
            Console.Write(srBack + "|");
            Thread.Sleep(250);
            Console.Write(srBack + "/");
            Thread.Sleep(250);
        }

        Console.WriteLine(""); //end the space for the animation
    }

    protected void jcDisplayStartMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_srName} Activity \n");
        Console.WriteLine($"{_srDescription}\n");
        jcSetTime();

    }

    protected void jcDisplayEndMessage(){
        Console.WriteLine("Well Done! \n");
        Console.WriteLine($"You have completed another {_srTime} seconds of the {_srName} activity.");
    }

    protected void jcSetTime(){
        Console.Write("How long, in seconds, would you like your session?");
        _srTime = float.Parse(Console.ReadLine());
    }

    protected float jcGetTime(){
        return _srTime;
    }
    public void jcPause(int jcSec){
    // jcTime is measured in seconds
        int jcMilliseconds = jcSec * 1000;
        Thread.Sleep(jcMilliseconds);
    }
    protected void jcCountdown(int i){
        for (; i > 0; i--){
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}