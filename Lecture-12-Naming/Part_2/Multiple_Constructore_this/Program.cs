
public class Circle
{
    private double radius;
    private string color;

    // Constructor 1: No parameters
    public Circle() : this(1.0)
    {
        Console.WriteLine("Constructor 1 executed");
    }

    // Constructor 2: One parameter
    public Circle(double radius)
    {
        this.radius = radius;
        Console.WriteLine("Constructor 2 executed");
    }

    // Constructor 3: Two parameters
    public Circle(double radius, string color) : this(radius)
    {
        this.color = color;
        Console.WriteLine("Constructor 3 executed");
    }

    public void PrintInfo()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Color: " + (color ?? "Not specified"));
    }
}

public class Test
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Circle 1 ---");
        Circle circle1 = new Circle();
        circle1.PrintInfo();

        Console.WriteLine();

        Console.WriteLine("--- Circle 2 ---");
        Circle circle2 = new Circle(5.0);
        circle2.PrintInfo();

        Console.WriteLine();

        Console.WriteLine("--- Circle 3 ---");
        Circle circle3 = new Circle(10.0, "Red");
        circle3.PrintInfo();
    }
}
