
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Loop through all command-line arguments
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("Arg #" + i + ": " + args[i]);
        }
    }
}
