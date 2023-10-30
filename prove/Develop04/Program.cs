using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity("test", "test", 5);

        activity.jcAnimation();
        activity.jcPause(5);
        activity.jcAnimation();
    }
}