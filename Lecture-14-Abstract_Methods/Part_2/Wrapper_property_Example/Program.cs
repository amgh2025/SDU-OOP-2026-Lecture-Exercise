class Wrapper
{
    // Private backing field
    private int wrapped;

    public int Wrapped
    {
        get
        {
            return -1 * wrapped;
        }

        set
        {
            wrapped = -1 * value;
        }
    }
}

class Program
{
    static void Main()
    {
        Wrapper w = new Wrapper();

        w.Wrapped = 10;

        Console.WriteLine(w.Wrapped);

        w.Wrapped = -5;

        Console.WriteLine(w.Wrapped);
    }
}
