using System;

class CheckListGoal : Goal
{
    protected int _AmountCompleted;
    protected int _target;
    protected int _bonus;


    public CheckListGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        this._target = target;
        this._bonus = bonus;
    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
return false;
    }

    public string GetDetailString()
    {
return "";
    }

    public override string GetStringRepresentation()
    {
        return (_shortName);
    }

}