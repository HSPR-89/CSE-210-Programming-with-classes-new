using System;

class ReflectingActivity : Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;

    public ReflectingActivity(string _name, string _description) : base (_name,_description)
    {

    }
    public void Run()
    {

    }

    public string GetRandomPrompt()
    {

        return $"";
    }

    public string GetRamdonQuestion()
    {
        return $"";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }

}