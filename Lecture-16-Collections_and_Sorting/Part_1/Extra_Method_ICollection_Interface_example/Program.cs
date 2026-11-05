
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Interface-based polymorphism
        ICollection<string> students = new List<string>();

        // 1. Add()
        students.Add("Peter");
        students.Add("Henrik");
        students.Add("Emma");

        // 2. Count
        Console.WriteLine("Count: " + students.Count);

        // 3. Contains()
        bool exists = students.Contains("Peter");
        Console.WriteLine("Contains Peter: " + exists);

        // 4. IsReadOnly- True - NotSupportedException
        Console.WriteLine("IsReadOnly: " + students.IsReadOnly);

        // 5. CopyTo()
        string[] studentArray = new string[students.Count];

        students.CopyTo(studentArray, 0);

        Console.WriteLine("\nCopied Array:");

        foreach (string name in studentArray)
        {
            Console.WriteLine(name);
        }

        // 6. Remove()
        bool removed = students.Remove("Henrik");
        Console.WriteLine("\nHenrik removed: " + removed);

        // 7. Clear()
        students.Clear();

        Console.WriteLine("Count after Clear: " + students.Count);
    }
}
