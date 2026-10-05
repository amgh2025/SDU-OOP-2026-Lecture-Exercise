Rectangle p = new Rectangle();

p.width = 1;
p.height = 2;

Console.WriteLine("area = (" + p.getArea() + ")");


public class Rectangle
{
    //public Point center;
    //public Point? center;
    public double width;
    public double height;

    public double getArea()
    {
        return width * height;
    }
}


// We dinefe this class for center of area
public class Point
{
    public double x;
    public double y;
}
