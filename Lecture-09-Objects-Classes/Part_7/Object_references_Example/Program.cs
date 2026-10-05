Rectangle r1, r2, r3, r4;

r1 = new Rectangle(11, 12, "red");
r2 = new Rectangle(21, 22, "blue");

r3 = null;

r4 = r2;


// Assign values to the instance variables
// of the objects referenced by r1 and r2

r1.width = 13;
r2.width = 23;

Console.WriteLine("Original state - variable");

Console.WriteLine(r2.width);


// Change width using r4

r4.width = 43;

Console.WriteLine("After change .....");
Console.WriteLine(r2.width);


public class Rectangle
{
    public int width;
    public int height;
    public string color;

    public Rectangle(int widthValue, int heightValue, string colorValue)
    {
        width = widthValue;
        height = heightValue;
        color = colorValue;
    }

    public int getArea()
    {
        return width * height;
    }

    public void setColor(string colorValue)
    {
        color = colorValue;
    }
}
