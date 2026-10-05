Circle c1 = new Circle();
Circle c2 = new Circle(10);
Circle c3 = new Circle(5, 10);
Circle c4 = new Circle(-5, "red");


public class Circle
{
    public double x;
    public double y;
    public double radius;
    public string color;

    // Constructor 1: Does not assign values - Just print
    public Circle()
    {
        Console.WriteLine("A Circle object was created.");
    }

    // Constructor 2: Assigns an initial value
    public Circle(double radiusValue)
    {
        radius = radiusValue;
    }

    // Constructor 3: Assigns several initial values
    public Circle(double xValue, double radiusValue)
    {
        x = xValue;
        radius = radiusValue;
    }

    // Constructor 4: Checks the value before assigning it by making condition
    public Circle(double radiusValue, string colorValue)
    {
        if (radiusValue > 0)
        {
            radius = radiusValue;
        }
        else
        {
            radius = 1;
        }

        color = colorValue;
    }
}
