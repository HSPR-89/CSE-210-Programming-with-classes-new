using System;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string _name, string _description)
    {
        this._name = _name;
        this._description = _description;

    }

    public string Getname()
    {
        return _name;
    }

    public void Setname(string name)
    {
        _name = name;
    }

    public string Getdescription()
    {
        return _description;
    }

    public void Setdescription(string description)
    {
        _description = description;
    }

    public int Getduration()
    {
        return _duration;
    }

    public void Setduration(int duration)
    {
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(2);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n");
        Console.WriteLine($"Well done!!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(2);
    }


    public void ShowSpinner(int seconds)
    {


        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character

            // Console.WriteLine("\n \n");

        }

    }

    public void ShowCountDown(int seconds)
    {

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character

        }

    }
}

