
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        ISet<string> students = new HashSet<string>();

        // 1. Add
        Console.WriteLine(students.Add("Peter"));
        Console.WriteLine(students.Add("Henrik"));
        Console.WriteLine(students.Add("Sara"));
        Console.WriteLine(students.Add("Peter"));

        // 2. Count
        Console.WriteLine("Count: " + students.Count);

        // 3. Contains
        Console.WriteLine("Contains Peter: " + students.Contains("Peter"));

        // Create another Set
        ISet<string> group = new HashSet<string>();
        group.Add("Peter");
        group.Add("Sara");

        // 4. IsSubsetOf
        Console.WriteLine("Subset: " + group.IsSubsetOf(students));

        // 5. IsSupersetOf
        Console.WriteLine("Superset: " + students.IsSupersetOf(group));

        // 6. Overlaps
        Console.WriteLine("Overlaps: " + students.Overlaps(group));

        // 7. IntersectWith
        ISet<string> common = new HashSet<string>(students);
        common.IntersectWith(group);

        Console.WriteLine("Common students:");
        foreach (string name in common)
        {
            Console.WriteLine(name);
        }

        // 8. UnionWith
        ISet<string> all = new HashSet<string>(students);
        all.UnionWith(new string[] { "Emma", "Peter" });

        Console.WriteLine("Union:");
        foreach (string name in all)
        {
            Console.WriteLine(name);
        }

        // 9. Clear
        students.Clear();
        Console.WriteLine("Final count: " + students.Count);
    }
}
