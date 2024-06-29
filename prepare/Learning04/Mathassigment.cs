using System;

class MathAssignment : Assignment
{
    protected string _textbookSection = "";
    protected string _problems = "";

    public string GettextbookSection()
    {
        return _textbookSection;
    }

    public void SettextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string Getproblems()
    {
        return _problems;
    }

    public void Setproblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_studentName}-{_topic}\nSection {_textbookSection} Problems {_problems}";
    }
}