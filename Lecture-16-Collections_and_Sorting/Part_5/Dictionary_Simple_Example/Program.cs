
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a Dictionary
        Dictionary<string, int> months =
            new Dictionary<string, int>();

        // Add key-value pairs
        months.Add("May", 31);
        months.Add("Jan", 31);
        months.Add("Jun", 30);

        // Access a value using its key
        Console.WriteLine(months["May"]);
        Console.WriteLine(months["Jun"]);

        // Update a value
        months["Jun"] = 31;

        Console.WriteLine("Updated Jun: " + months["Jun"]);

        // Check if a key exists
        Console.WriteLine(months.ContainsKey("Jan"));

        // Remove an element using its key
        months.Remove("May");

        // Print all key-value pairs
        foreach (KeyValuePair<string, int> item in months)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}
