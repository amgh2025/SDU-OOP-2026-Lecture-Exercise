Point p0 = new Point(0, 0, "black");
Point p1 = new Point(1, 1, "red");

p1.SetColor("blue");

Console.WriteLine("dist between p0 and p1 is " + p0.Dist(p1));
Console.WriteLine("p1 is " + p1.GetColor());


class Point
{
    double x;
    double y;
    string color;

    public Point(double xValue, double yValue, string colorValue)
    {
        x = xValue;
        y = yValue;
        color = colorValue;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string colorValue)
    {
        color = colorValue;
    }

    public double Dist(Point b)
    {
        return Math.Sqrt((x - b.x) * (x - b.x) + (y - b.y) * (y - b.y));
    }
}
