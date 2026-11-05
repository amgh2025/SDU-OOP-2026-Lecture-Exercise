
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        IList<string> students = new List<string>();

        students.Add("Peter");
        students.Add("Henrik");
        students.Add("Emma");

        // Print original list
        Console.WriteLine("Before Update:");

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // Find Henrik's position
        int index = students.IndexOf("Henrik");

        // Update Henrik to Thomas
        if (index != -1)
        {
            students[index] = "Thomas";
        }

        // Print updated list
        Console.WriteLine("\nAfter Update:");

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}
