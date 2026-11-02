class Pair<T1, T2>
{
    public T1 A { get; set; }
    public T2 B { get; set; }

    public Pair(T1 a, T2 b)
    {
        A = a;
        B = b;
    }

    public void SetA(T1 a)
    {
        A = a;
    }

    public void SetB(T2 b)
    {
        B = b;
    }

    public override string ToString()
    {
        return "Generic(" + A + ", " + B + ")";
    }
}

class Program
{
    static void Main()
    {
        // Example 1: int and double
        Pair<int, double> p1 = new Pair<int, double>(42, 3.14);

        p1.SetA(56);
        Console.WriteLine(p1);

        // Example 2: double and int
        Pair<double, int> p2 =new Pair<double, int>(3.14, 42);

        p2.SetB(56);
        Console.WriteLine(p2);

        // Example 3: string and int
        Pair<string, int> p3 =new Pair<string, int>("Peter", 25);

        Console.WriteLine(p3);

        // Example 4: string and string
        Pair<string, string> p4 =new Pair<string, string>("Henrik", "Emma");

        Console.WriteLine(p4);
    }
}
