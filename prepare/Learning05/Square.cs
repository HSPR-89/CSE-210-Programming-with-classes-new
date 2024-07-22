using System;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Square : Shape
{
    private double _side;

    public Square(double _side) : base ()
    {
        this._side = _side;
    }

    public override double GetArea()
    {
        double area = (_side) *(_side);
        return area;
    }
}