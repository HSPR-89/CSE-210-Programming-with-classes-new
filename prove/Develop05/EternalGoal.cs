using System;

class EternalGoal : Goal
{
   
    public EternalGoal(string name, string description, string points) : base(name, description, points)
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