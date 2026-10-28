// Interface defines the property
interface IWrapper
{
    int Wrapped { get; set; }
}

// Class implements the interface
class Wrapper : IWrapper
{
    // Private backing field
    private int wrapped;

    // Implement the interface property
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
        // Interface reference
        IWrapper w = new Wrapper();

        // Calls the setter in Wrapper
        w.Wrapped = 10;

        // Calls the getter in Wrapper
        Console.WriteLine(w.Wrapped);

        // Change the value
        w.Wrapped = -5;

        Console.WriteLine(w.Wrapped);
    }
}
