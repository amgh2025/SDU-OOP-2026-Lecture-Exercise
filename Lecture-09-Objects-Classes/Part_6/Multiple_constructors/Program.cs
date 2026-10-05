Circle c1 = new Circle();
Circle c2 = new Circle(5, 10);
Circle c3 = new Circle(2, 3, 4);

Console.WriteLine("c1: x = " + c1.x + ", y = " + c1.y + ", radius = " + c1.radius);
Console.WriteLine("c2: x = " + c2.x + ", y = " + c2.y + ", radius = " + c2.radius);
Console.WriteLine("c3: x = " + c3.x + ", y = " + c3.y + ", radius = " + c3.radius);


public class Circle
{
    public double x, y, radius;

    public Circle()
    {
        x = 1.3 * 10;
        y = 1.3 * 10;
        radius = 1.3 * 17;
        }

    public Circle(double x_val, double radius_val)
    {
        x = x_val;
        y = 1.3 * 10;
        radius = radius_val;
    }

    public Circle(double x_val, double y_val, double radius_val)
    {
        x = x_val;
        y = y_val;
        radius = radius_val;
    }
}
