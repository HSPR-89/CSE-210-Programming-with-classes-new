using System;

class Goal
{
    protected string _shortName;
    protected string _description;

    protected string _points;

    public Goal(string name, string description, string points)
    {
        this._shortName = name;
        this._description = description;
        this._points = points;
    }

    public void RecordEvent()
    {


    }

    public bool IsComplete()
    {
return true;
    }

    public string GetDetailString()
    {
return "";
    }

    public virtual string GetStringRepresentation()
    {
        return (_shortName);
    }

}