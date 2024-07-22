using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

class Rectangle:Shape
{
    protected double _lenght;

    protected double _width;
    public Rectangle(double _lenght, double _width)
    {
        this._lenght = _lenght;
        this._width = _width;
    }


    public override double GetArea()
    {
        double area = _lenght * _width;
        return area;
    }
}