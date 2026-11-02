class IntegerDoublePair
{
    public int A { get; set; }
    public double B { get; set; }

    public IntegerDoublePair(int a, double b)
    {
        A = a;
        B = b;
    }

    public void SetA(int a)
    {
        A = a;
    }

    public void SetB(double b)
    {
        B = b;
    }

    public override string ToString()
    {
        return "int+double(" + A + ", " + B + ")";
    }
}

class DoubleIntegerPair
{
    public double A { get; set; }
    public int B { get; set; }

    public DoubleIntegerPair(double a, int b)
    {
        A = a;
        B = b;
    }

    public void SetA(double a)
    {
        A = a;
    }

    public void SetB(int b)
    {
        B = b;
    }

    public override string ToString()
    {
        return "double+int(" + A + ", " + B + ")";
    }
}

class Program
{
    static void Main()
    {
        IntegerDoublePair p1 =new IntegerDoublePair(42, 3.14);

        p1.SetA(56);
        Console.WriteLine(p1);

        DoubleIntegerPair p2 = new DoubleIntegerPair(3.14, 42);

        p2.SetB(56);
        Console.WriteLine(p2);
    }
}
