using System;
using System.Drawing;

abstract class Shape
{
    private string _color;

    public Shape()
    {

    }
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string _color)
    {
        this._color = _color;
    }

    public abstract double GetArea();

}