
class Wrapper
{
    public int Wrapped { get; set; }
}

class Program
{
    static void Main()
    {
        Wrapper w = new Wrapper();

        w.Wrapped = 10;  // Calls set
        Console.WriteLine(w.Wrapped); // Calls get

        w.Wrapped = 20;  // Calls set
        Console.WriteLine(w.Wrapped); // Calls get
    }
}
