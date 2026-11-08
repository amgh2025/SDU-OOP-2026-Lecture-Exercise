
using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        // 1. File name
        string filename = "theBook.txt";

        try
        {
            // 2. Open the file for writing
            TextWriter tw = new StreamWriter(File.OpenWrite(filename));

            // 3. Write text into the file
            tw.WriteLine("This is a short book.");
            tw.Write("The end.");

            // 4. Close the file
            tw.Close();

            Console.WriteLine("File saved successfully!");

            // 5. Display the full file path
            Console.WriteLine("File location: " +Path.GetFullPath(filename));

            // 6. Read the file content
            Console.WriteLine("\nFile content:");
            Console.WriteLine(File.ReadAllText(filename));
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Invalid path.");
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("You don't have access to the file.");
            Console.WriteLine(ex.Message);
        }
    }
}
