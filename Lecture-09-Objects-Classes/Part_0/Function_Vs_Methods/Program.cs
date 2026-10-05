Point p1 = new Point(1, 1, "red");

p1.SetColor("blue");






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

    public void SetColor(string colorValue)
    {
        color = colorValue;
    }
}
