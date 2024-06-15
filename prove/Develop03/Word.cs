using System;
using System.ComponentModel;

class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public void Show()
    {
        isHidden = false;
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    public string GetDisplayText()
    {
        if (isHidden == true)
        {
            return new string('_', text.Length) + " ";
        }
        return $"{text} ";
    }
}