using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;

        while (number != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess>number)
            {
                Console.WriteLine("Lower");
            }

            else if (guess<number)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guess it");
            }

        }


    }
}