
using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string filePath = "students.txt";

        // 1. Create a new file
        // File.Create() returns a FileStream
        using (FileStream fs = File.Create(filePath))
        {
            Console.WriteLine("File created!");
        }

        // 2. Check if the file exists
        if (File.Exists(filePath))
        {
            Console.WriteLine("File exists!");
        }

        // 3. Write text into the file
        File.WriteAllText(filePath, "Peter\nSara\nHenrik");

        Console.WriteLine("Data written to file!");

        // 4. Read text from the file
        string content = File.ReadAllText(filePath);

        Console.WriteLine("File content:");
        Console.WriteLine(content);

        // 5. Add more text to the file
        File.AppendAllText(filePath, "\nEmma");

        Console.WriteLine("Emma added to file!");

        // 6. Delete the file
        /*File.Delete(filePath);

        Console.WriteLine("File deleted!");*/

        // 7. Check again
        Console.WriteLine("File exists: " + File.Exists(filePath));
    }
}
