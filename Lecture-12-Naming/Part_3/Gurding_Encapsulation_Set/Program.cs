
public class Circle
{
    private double radius = 1.0;

    // Accessor method
    public double GetRadius()
    {
        return radius;
    }

    // Mutator method with guarding
    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Radius cannot be negative!");
        }

        this.radius = radius;
    }
}

public class Test
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();

        Console.WriteLine("Initial radius: "+ circle.GetRadius());

        // Valid value
        circle.SetRadius(5.0);

        Console.WriteLine("New radius: " + circle.GetRadius());

        // Invalid value
        try
        {
            circle.SetRadius(-3.0);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // Check radius after invalid attempt
        Console.WriteLine("Final radius: " + circle.GetRadius());
    }
}
