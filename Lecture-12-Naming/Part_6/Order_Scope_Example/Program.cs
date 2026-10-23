public class NumberExample
{
    public int f = 5;

    // k depends on f
    //public int k = f + 1; // Compilation error


    public int k;
    public NumberExample()
    {
        k = f + 1;
    }
}

public class Test
{
    static void Main(string[] args)
    {
        NumberExample example = new NumberExample();

        Console.WriteLine(example.k);
    }
}
