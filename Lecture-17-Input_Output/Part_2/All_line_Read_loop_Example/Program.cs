
using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string filename = "theBook.txt";

        // 1. Create a file with 50 lines
        using (StreamWriter writer = new StreamWriter(filename))
        {
            for (int i = 1; i <= 50; i++)
            {
                writer.WriteLine("This is line number " + i);
            }
        }

        Console.WriteLine("File created with 50 lines!");

        // 2. Read the file using StreamReader
        using (StreamReader reader = new StreamReader(filename))
        {
            string? line;

            // 3. Read and print every line using while
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
