// One generic class for different data types
class Pair<T>
{
    public T A { get; set; }
    public T B { get; set; }

    // Constructor
    public Pair(T a, T b)
    {
        A = a;
        B = b;
    }

    // Change the first value
    public void SetA(T a)
    {
        A = a;
    }

    // Change the second value
    public void SetB(T b)
    {
        B = b;
    }

    public override string ToString()
    {
        return "Pair(" + A + ", " + B + ")";
    }
}

class Program
{
    static void Main()
    {
        // Example 1: Integer
        Pair<int> p1 = new Pair<int>(10, 20);
        Console.WriteLine(p1);

        p1.SetA(50);
        Console.WriteLine(p1);

        // Example 2: Double
        Pair<double> p2 = new Pair<double>(1.5, 2.5);
        Console.WriteLine(p2);

        p2.SetB(4.5);
        Console.WriteLine(p2);

        // Example 3: String
        Pair<string> p3 = new Pair<string>("Ali", "Sara");
        Console.WriteLine(p3);

        p3.SetA("Peter");
        Console.WriteLine(p3);

        // Example 4: Boolean
        Pair<bool> p4 = new Pair<bool>(true, false);
        Console.WriteLine(p4);
    }
}
