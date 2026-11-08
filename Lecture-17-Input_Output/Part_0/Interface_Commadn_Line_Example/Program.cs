
using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        TextReader reader = Console.In;

        while (true)
        {
            Console.Out.WriteLine("Make a choice:");
            Console.Out.WriteLine("1) Make the program say hello!");
            Console.Out.WriteLine("2) Quit the program.");

            string? line = reader.ReadLine();

            if (line == null)
            {
                break;
            }

            int choice = int.Parse(line);

            if (choice == 1)
            {
                Console.Out.WriteLine("Hello!");
            }
            else if (choice == 2)
            {
                break;
            }
        }

        Console.WriteLine("Program finished.");
    }
}
