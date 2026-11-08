
using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        // 1. Get the application output directory
        string folderPath = AppContext.BaseDirectory;

        Console.WriteLine("Folder: " + folderPath);

        // 2. Create XML content
        string xml = """
        <?xml version="1.0" encoding="utf-8"?>
        <Student>
            <Id>101</Id>
            <Name>Peter</Name>
            <Age>22</Age>
        </Student>
        """;

        // 3. Save XML file
        string xmlPath = Path.Combine(folderPath, "students.xml");

        File.WriteAllText(xmlPath, xml);

        Console.WriteLine("\nXML file saved!");
        Console.WriteLine("XML path: " + xmlPath);

        // 4. Read XML file
        Console.WriteLine("\nXML content:");
        Console.WriteLine(File.ReadAllText(xmlPath));

        // 5. Find DLL files
        string[] dllFiles = Directory.GetFiles(folderPath, "*.dll");

        Console.WriteLine("\nDLL files:");

        foreach (string file in dllFiles)
        {
            Console.WriteLine(Path.GetFileName(file));
        }

        // 6. Find XML files
        string[] xmlFiles = Directory.GetFiles(folderPath, "*.xml");

        Console.WriteLine("\nXML files:");

        foreach (string file in xmlFiles)
        {
            Console.WriteLine(Path.GetFileName(file));
        }
    }
}
