using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a LinkedList
        LinkedList<string> students =new LinkedList<string>();

        // 1. Add elements at the end
        students.AddLast("Peter");
        students.AddLast("Henrik");
        students.AddLast("Emma");

        Console.WriteLine("Original LinkedList:");
        PrintStudents(students);

        // 2. Add at the beginning
        students.AddFirst("Thomas");

        Console.WriteLine("\nAfter AddFirst:");
        PrintStudents(students);

        // 3. Add at the end
        students.AddLast("Sara");

        Console.WriteLine("\nAfter AddLast:");
        PrintStudents(students);

        // 4. Add after a specific node
        LinkedListNode<string> node =students.Find("Peter");

        if (node != null)
        {
            students.AddAfter(node, "Lucas");
        }

        Console.WriteLine("\nAfter AddAfter Peter:");
        PrintStudents(students);

        // 5. Remove first element
        students.RemoveFirst();

        Console.WriteLine("\nAfter RemoveFirst:");
        PrintStudents(students);

        // 6. Remove last element
        students.RemoveLast();

        Console.WriteLine("\nAfter RemoveLast:");
        PrintStudents(students);
    }

    static void PrintStudents(LinkedList<string> students)
    {
        foreach (string student in students)
        {
            Console.Write(student + " -> ");
        }

        Console.WriteLine("null");
    }
}
