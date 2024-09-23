using System;

class SimpleGoal:Goal
{
    protected string _IsComplete;
    

    public SimpleGoal(string name, string description, string points) : base (name, description, points)
    {

    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
return true;
    }

    public override string GetStringRepresentation() 
    {
return (_shortName);
    }

}