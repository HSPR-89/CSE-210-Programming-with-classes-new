using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

class Reference
{
    private string book;
    private int chapter;
    private int verse;
    private int endVerse;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = startVerse;
        this.endVerse = endVerse;
    }

    public string GetDisplayText()
    {
       string endversetext="";
       if (endVerse>0)
       {
        endversetext= $"-{endVerse}";
       }
        return $"{book} {chapter}:{verse}{endversetext} ";

    }
}