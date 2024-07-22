using System;

class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts;

    public ListingActivity(string _name, string _description) : base(_name, _description)
    {
        _prompts = new List<string>()
      {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
      };


    }

    public void Run()
    {
        Console.WriteLine("List a as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in:");
        ShowCountDown(3);
        GetListFromUser();

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int prompts = random.Next(0, _prompts.Count);
        Console.WriteLine($"---{_prompts[prompts]}---");
    }

    public List<string> GetListFromUser()
    {
        List<string> answer = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            string answers = Console.ReadLine();
            currentTime = DateTime.Now;
            answer.Add(answers);
        }
        _count = answer.Count();
        Console.WriteLine($"You listed {_count} items!");
        return answer;
    }

}