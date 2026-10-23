
public class Test
{
    static void Main(string[] args)
    {
        // 1. Mathematical constant
        Console.WriteLine("PI: " + Math.PI);

        // 2. Square root
        Console.WriteLine("Square root: " + Math.Sqrt(25));

        // 3. Power
        Console.WriteLine("Power: " + Math.Pow(2, 3));

        // 4. Absolute value
        Console.WriteLine("Absolute: " + Math.Abs(-10));

        // 5. Maximum and minimum
        Console.WriteLine("Maximum: " + Math.Max(10, 20));
        Console.WriteLine("Minimum: " + Math.Min(10, 20));

        // 6. Sine calculation
        Console.WriteLine("Sin(2 * PI): "+ Math.Sin(2 * Math.PI));

        // 7. Rounding
        Console.WriteLine("Rounded: "+ Math.Round(3.756, 2));
    }
}
