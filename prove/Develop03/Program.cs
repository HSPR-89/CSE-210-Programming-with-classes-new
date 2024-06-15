using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string book = "Mosiah";
        int chapter = 2;
        int verse = 17;
        int endverse = 18;

        Reference reference = new Reference(book, chapter, verse, endverse);
        string mosiah = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.";
        Scripture scripture = new Scripture(reference, mosiah);

        List<int> hiddenIndices = new List<int>();
        while (hiddenIndices.Count < scripture.WordsCount())
        {
            Console.WriteLine("Press Enter to hide a few words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            Random random = new Random();
            int wordsToHide = random.Next(1, 4);

            for (int i = 0; i < wordsToHide; i++)
            {
                int index = random.Next(0, scripture.WordsCount());
                if (!hiddenIndices.Contains(index))
                {
                    hiddenIndices.Add(index);
                    scripture.HideRamdomWords(index);
                }
            }

            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
        }
        Console.WriteLine("All words in the scripture are now hidden.");

    }
}