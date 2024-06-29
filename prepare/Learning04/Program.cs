using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetstudentName("Samuel Bennett");
        assignment1.Settopic("Multiplication");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment();
        assignment2.SetstudentName("Roberto Rodriguez");
        assignment2.Settopic("Fractions");
        assignment2.SettextbookSection("7.3");
        assignment2.Setproblems("8-19");

        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssigment assignment3 = new WritingAssigment();
        assignment3.SetstudentName("Mary Waters");
        assignment3.Settopic("European History");
        assignment3.Setttitle("7.3");
        

        Console.WriteLine(assignment3.GetWritingInformation());
    }
}