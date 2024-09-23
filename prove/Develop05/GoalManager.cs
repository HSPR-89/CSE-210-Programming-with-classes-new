using System;
using System.Runtime.InteropServices;

class GoalManager
{
    protected int _score;
    protected List<Goal> _goals;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Your Eternal Quest Program!");
        Console.WriteLine($"You have {_score} points");

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");


            Console.Write("Please select a choice from the menu:  ");
            string choice = Console.ReadLine();


            switch (choice)
            {

                case "1":
                    CreateGoal();
                    break;

                case "2":
                    ListGoalNames();
                    break;

                case "3":

                    break;

                case "4":

                    break;

                case "5":

                    break;


                case "6":
                    Console.WriteLine("Goodbye!");
                    return;


                default:
                    Console.WriteLine("Invalid selection, please enter a number 1-6.");
                    break;
            }
        }
    }




    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {
        int i = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetStringRepresentation()}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            goal.GetDetailString();
        }
    }

    public void CreateGoal()
    {
        
        
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist GoalGoal");

            Console.Write("Which type of goal would you like to create?:  ");
            string choice1 = Console.ReadLine();

            Console.Write("What is the name of your goal?:  ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it?:  ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();


            switch (choice1)
            {

                case "1":
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    _goals.Add(simpleGoal);
                    break;

                case "2":
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                    break;

                case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus:  ");
                    int target = Convert.ToInt32(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times?:  ");
                    int bonus = Convert.ToInt32(Console.ReadLine());

                    CheckListGoal checklistGoal = new CheckListGoal(name, description, points, target, bonus);

                    _goals.Add(checklistGoal);

                    break;

                default:
                    Console.WriteLine("Invalid selection, please enter a number 1-6.");
                    break;


            }
        
    }


    public void RecordEvent()
    {
        Console.WriteLine($"The goals are: ");
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }


}