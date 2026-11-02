// Class for integer values
class IntegerPair
{
    int a, b;

    public IntegerPair(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public void SetA(int a)
    {
        this.a = a;
    }

    public void SetB(int b)
    {
        this.b = b;
    }

    public override string ToString()
    {
        return "int(" + a + ", " + b + ")";
    }
}

// Class for double values
class DoublePair
{
    double a, b;

    public DoublePair(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public void SetA(double a)
    {
        this.a = a;
    }

    public void SetB(double b)
    {
        this.b = b;
    }

    public override string ToString()
    {
        return "double(" + a + ", " + b + ")";
    }
}

class Program
{
    static void Main()
    {
        // IntegerPair example
        IntegerPair p1 = new IntegerPair(10, 20);

        Console.WriteLine(p1);

        p1.SetA(50);
        p1.SetB(60);

        Console.WriteLine(p1);

        // DoublePair example
        DoublePair p2 = new DoublePair(1.5, 2.5);

        Console.WriteLine(p2);

        p2.SetA(3.5);
        p2.SetB(4.5);

        Console.WriteLine(p2);
    }
}
