using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

class Circle : Shape
{
    protected double _radius;

    public Circle(double _radius)
    {
        this._radius = _radius;
}



    public override double GetArea()
    {
        double area = Math.PI * _radius * _radius;
        return area;
    }
}