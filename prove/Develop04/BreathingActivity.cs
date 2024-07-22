using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string _name, string _description) : base(_name, _description)
    {

    }
    public void Run()
    {

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("\n \n");
            Console.Write($"Breathe in...");
            ShowCountDown(4);

            Console.Write("\n");
            Console.Write($"Now Breathe out...");
            ShowCountDown(6);

            currentTime = DateTime.Now;
        }
    }
}