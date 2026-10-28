// Base class
class Shape
{
    public string Name { get; set; }

    public Shape(string name)
    {
        Name = name;
    }

    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// Interface 1: void method
interface IStrokable
{
    void SetStroke(string color);
}

// Interface 2: void method
interface IFillable
{
    void Fill(string color);
}

// Interface 3: string return type
interface ISerializable
{
    string Save();
}

// One base class and three interfaces
class Circle : Shape, IStrokable, IFillable, ISerializable
{
    public Circle(string name) : base(name)
    {
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing a circle: " + Name);
    }

    public void SetStroke(string color)
    {
        Console.WriteLine("Circle border color: " + color);
    }

    public void Fill(string color)
    {
        Console.WriteLine("Filling circle with: " + color);
    }

    // Must return a string
    public string Save()
    {
        return "Circle saved: " + Name;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle("My Circle");

        circle.Draw();
        circle.SetStroke("Black");
        circle.Fill("Red");

        // Save() returns a string
        string result = circle.Save();
        Console.WriteLine(result);

        // Interface polymorphism
        ISerializable item = circle;
        Console.WriteLine(item.Save());
    }
}
