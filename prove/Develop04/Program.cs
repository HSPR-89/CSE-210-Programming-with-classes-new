using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {


        //Welcome banner
        Console.WriteLine("Welcome to Your Mindfulness Program!");

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            //Requests user selection for action to take
            Console.Write("Please select a choice from the menu:  ");
            string choice = Console.ReadLine();

            //Calls class methods per user selection
            switch (choice)
            {
                //Adds new entry
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.Run();
                    breathingActivity.DisplayEndingMessage();
                    Console.Clear();

                    break;

                //Displays added entries
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectingActivity.DisplayStartingMessage();
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndingMessage();
                    Console.Clear();
                    break;

                //Loads entries from a file
                case "3":
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.DisplayStartingMessage();
                    listingActivity.Run();
                    listingActivity.DisplayEndingMessage();
                    Console.Clear();
                    break;

                //Exits program
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;

                //Handles invalid input
                default:
                    Console.WriteLine("Invalid selection, please enter a number 1-4.");
                    break;
            }
        }
    }


}

