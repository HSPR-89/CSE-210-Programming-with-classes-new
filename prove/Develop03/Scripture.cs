using System;
class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        var splitwords = text.Split(" ");
        words = new List<Word>();
        foreach (string word in splitwords)
        {
            Word word1 = new Word(word);
            words.Add(word1);
        }
    }

    public void HideRamdomWords(int numberToHide)
    {
        words[numberToHide].Hide();
    }

    public string GetDisplayText()
    {
        string wordstogether = reference.GetDisplayText();
        foreach (var word in words)
        {
            wordstogether += word.GetDisplayText();
        }
        return $"{wordstogether}";


    }

    public bool IsCompletlyHidden()
    {
        return false;
    }

    public int WordsCount()
    {
        return words.Count;
    }
}
