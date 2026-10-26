class Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Shape");
    }
}

class Rectangle : Shape
{
    public new void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }
}

class Circle : Shape
{
    public new void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

class Program
{
    static void Main()
    {
        Shape s1 = new Shape();
        Shape s2 = new Rectangle();
        Shape s3 = new Circle();

        s1.Draw();
        s2.Draw();
        s3.Draw();

        Rectangle r = new Rectangle();
        r.Draw();

        Circle c = new Circle();
        c.Draw();
    }
}
