using System;

class WritingAssigment : Assignment
{
    protected string _title = "";

    public string Gettitle()
    {
        return _title;
    }

    public void Setttitle(string title)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
         return $"{_studentName}-{_topic}\nSection {_title} by {_studentName}";
    }
}