Shape[] shapes = new Shape[] {
    new Shape(),
    new Rectangle(),
    new Oval(),
    new RoundedRectangle()
};

foreach (Shape s in shapes)
{
    s.Draw();
}


public class Shape
{
    public  virtual void Draw()
    {
        Console.WriteLine("Cannot draw shape.");
    }
}


public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("code to draw a rectangle");
    }
}


public class Oval : Shape
{
    public override void Draw()
    {
        Console.WriteLine("code to draw an oval");
    }
}


public class RoundedRectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("code to draw a rounded rectangle");
    }
}
