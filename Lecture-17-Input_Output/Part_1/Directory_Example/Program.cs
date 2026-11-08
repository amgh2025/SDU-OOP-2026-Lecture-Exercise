
using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        // 1. Define a folder path
        string folderPath = "Students";

        // 2. Create a directory
        Directory.CreateDirectory(folderPath);
        Console.WriteLine("Folder created!");

        // 3. Check if the directory exists
        if (Directory.Exists(folderPath))
        {
            Console.WriteLine("Folder exists!");
        }

        // 4. Create subdirectories
        Directory.CreateDirectory("Students/Group1");
        Directory.CreateDirectory("Students/Group2");

        // 5. Get all subdirectories
        Console.WriteLine("Subdirectories:");

        string[] folders =Directory.GetDirectories(folderPath);

        foreach (string folder in folders)
        {
            Console.WriteLine(Path.GetFileName(folder));
        }

        // 6. Rename Group1 to GroupA
        Directory.Move( "Students/Group1","Students/GroupA"
        );

        Console.WriteLine("Group1 renamed to GroupA");

        // 7. Delete Group2
        Directory.Delete("Students/Group2");

        Console.WriteLine("Group2 deleted!");
    }
}
