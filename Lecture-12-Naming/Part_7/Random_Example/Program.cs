
using System;

public class Test
{
    static void Main(string[] args)
    {
        int seed = 42;
        Random random = new Random(seed);

        for (int i = 0; i < 10; i++)
        {
            // Random double between 0.0 and 1.0
            Console.WriteLine("Print Random double between 0.0 and 1.0");
            Console.WriteLine(random.NextDouble());

            // Random non-negative integer
            Console.WriteLine("Print Random non-negative integer");
            Console.WriteLine(random.Next());

            // Random integer between 1 and 6 (dice)
            Console.WriteLine("Random integer between 1 and 6 (dice)");
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine("********************************");
        }
    }
}
