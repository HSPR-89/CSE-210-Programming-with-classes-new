using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction initialize = new Fraction(5);
        initialize.Display();

        Fraction initialize2 = new Fraction();
        initialize2.Display();

        Fraction initialize3 = new Fraction(8, 4);
        initialize3.Display();

        initialize3.setTop(3);
        Console.WriteLine(initialize3.getTop());
        initialize3.Display();

        string fractionstring=initialize3.GetFractionString();
        Console.WriteLine(fractionstring);

        double decimalnumber=initialize3.GetDecimalValue();
        Console.WriteLine(decimalnumber);
    }

}