
class Divisor
{
    public void Divide(int a, int b)
    {
        int result = a / b;
        Console.WriteLine($"Result: {result}");
    }
}

class Program
{
    static void Main()
    {
        Divisor d = new Divisor();

        try
        {
            d.Divide(1, 0);
        }
        catch (Exception e)
        {
            Console.WriteLine("Unable to do division.");
            Console.WriteLine(e.Message);
        }
    }
}
