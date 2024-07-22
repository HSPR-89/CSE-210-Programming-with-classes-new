using System;

class ReflectingActivity : Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;

    public ReflectingActivity(string _name, string _description) : base(_name, _description)
    {
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>()
        {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        };
    }
    public void Run()
    {
        DisplayPrompt();
        DisplayQuestions();

    }

    public string GetRandomPrompt()
    {

        Random random = new Random();
        int prompts = random.Next(0, _prompts.Count);
        return $"Consider the following prompt: \n --- {_prompts[prompts]} ---";
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int questions = random.Next(0, _questions.Count);
        return $"{_questions[questions]}";
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Read();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as ther related to this expereince.");
        Console.Write($"you may begin in...");
        ShowCountDown(4);
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(2);
            Console.WriteLine("\n");
            currentTime = DateTime.Now;
        }
    }

}