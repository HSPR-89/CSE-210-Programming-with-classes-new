using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is you grade pertentage?: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }

        else if (number >= 80)
        {
            letter = "B";
        }

        else if (number >= 70)
        {
            letter = "C";
        }

        else if (number >= 60)
        {
            letter = "D";
        }

        else if (number < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (number >= 70)
        {
            Console.WriteLine("You have passed the course, Congratulations!");
        }

        else
        {
            Console.WriteLine("Nice try, you need to take the course again!");
        }
    }
}