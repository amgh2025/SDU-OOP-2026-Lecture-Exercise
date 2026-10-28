
public abstract class Shape
{
    public string Color { get; set; }

    // Concrete method: has an implementation
    public void SetColor(string color)
    {
        Color = color;

        // Calls the implementation in the derived class
        Draw();
    }

    // Abstract method: no implementation
    public abstract void Draw();
}

public class Circle : Shape
{
    // Must implement the abstract method
    public override void Draw()
    {
        Console.WriteLine("Drawing a " + Color + " Circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a " + Color + " Rectangle");
    }
}

class Program
{
    static void Main()
    {
        Shape s1 = new Circle();
        Shape s2 = new Rectangle();

        s1.SetColor("Red");
        s2.SetColor("Blue");

        // Not allowed: Cannot instantiate abstract class
        // Shape s3 = new Shape();
    }
}
