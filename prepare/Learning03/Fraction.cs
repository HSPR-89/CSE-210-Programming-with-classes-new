using System.Diagnostics;

class Fraction
{
    private int bottom;
    private int top;

    //clase contructora
    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    public Fraction(int topParam)
    {
        top = topParam;
        bottom = 1;
    }

    public Fraction(int topParam, int bottomParam)
    {
        top = topParam;
        bottom = bottomParam;
    }

    public int getTop()
    {
        return top;
    }

    public void setTop(int topParam)
    {
        top = topParam;
    }

    public int getBottom()
    {
        return bottom;
    }

    public void setBottom(int bottomParam)
    {
        bottom = bottomParam;
    }

    public void Display()
    {
        Console.WriteLine($"{top}/{bottom}");

    }

public string GetFractionString()
{
    return $"{top}/{bottom}";
}

public double GetDecimalValue()
{
    return (double)top/(double)bottom;
}


}