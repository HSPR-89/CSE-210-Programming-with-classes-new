using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        GoalManager goalManager = new GoalManager();

        //Welcome banner
        Console.WriteLine("Welcome to Your Eternal Quest Program!");
        Console.WriteLine($"You have  points");

       goalManager.Start();
       
            }
        }

