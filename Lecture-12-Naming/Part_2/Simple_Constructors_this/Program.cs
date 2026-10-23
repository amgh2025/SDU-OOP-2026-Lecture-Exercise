
public class Circle
{
    private double radius;

    // Constructor 1: accepts a radius
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Constructor 2: no parameters
    public Circle() : this(1.0)
    {
    }

    public void PrintRadius()
    {
        Console.WriteLine("Radius: " + radius);
    }
}

public class Test
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle();
        Circle circle2 = new Circle(5.0);

        circle1.PrintRadius();
        circle2.PrintRadius();
    }
}
