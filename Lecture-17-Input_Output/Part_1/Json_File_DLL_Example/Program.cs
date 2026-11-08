
using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        // 1. Get the application output directory
        string folderPath = AppContext.BaseDirectory;

        // 2. Create JSON content
        string json = """
        {
            "Id": 101,
            "Name": "Peter",
            "Age": 22
        }
        """;

        // 3. Save the JSON file in the DLL folder
        string jsonPath = Path.Combine(folderPath, "students.json");

        File.WriteAllText(jsonPath, json);

        Console.WriteLine("JSON file saved!");
        Console.WriteLine("JSON file: " + Path.GetFileName(jsonPath));
        Console.WriteLine("JSON path: " + jsonPath);

        // 4. Read the saved JSON file
        Console.WriteLine("\nJSON content:");
        Console.WriteLine(File.ReadAllText(jsonPath));

        // 5. Find all DLL files
        string[] dllFiles = Directory.GetFiles(folderPath, "*.dll");

        Console.WriteLine("\nDLL files:");

        foreach (string file in dllFiles)
        {
            Console.WriteLine(Path.GetFileName(file));
        }

        // 6. Display all JSON files
        string[] jsonFiles = Directory.GetFiles(folderPath, "*.json");

        Console.WriteLine("\nJSON files:");

        foreach (string file in jsonFiles)
        {
            Console.WriteLine(Path.GetFileName(file));
        }
    }
}
