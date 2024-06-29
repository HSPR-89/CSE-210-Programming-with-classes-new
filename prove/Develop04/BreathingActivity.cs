using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string _name, string _description) : base(_name, _description)
    {

    }
    public void Run()
    {
        ShowCountDown(40);
       /* Console.Write("Breathe in...");
        ShowCountDown(_duration);

        Console.Write("Now breathe out...");
        ShowCountDown(_duration);*/
    }


}