
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. ISet - Unique elements
        ISet<string> names = new HashSet<string>();

        names.Add("Peter");
        names.Add("Henrik");
        names.Add("Peter"); // Duplicate ignored

        Console.WriteLine("ISet:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // 2. IList - Ordered elements
        IList<string> students = new List<string>();

        students.Add("Peter");
        students.Add("Henrik");
        students.Add("Emma");

        Console.WriteLine("\nIList:");
        Console.WriteLine(students[0]); // Peter
        Console.WriteLine(students[1]); // Henrik

        // 3. LinkedList - Chain of elements
        LinkedList<string> cities =
            new LinkedList<string>();

        cities.AddLast("Kolding");
        cities.AddLast("Odense");
        cities.AddFirst("Copenhagen");

        Console.WriteLine("\nLinkedList:");
        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }

        // 4. Stack - Last In, First Out
        Stack<string> stack = new Stack<string>();

        stack.Push("Peter");
        stack.Push("Henrik");
        stack.Push("Emma");

        Console.WriteLine("\nStack:");
        Console.WriteLine(stack.Pop()); // Emma
        Console.WriteLine(stack.Pop()); // Henrik

        // 5. Queue - First In, First Out
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("Peter");
        queue.Enqueue("Henrik");
        queue.Enqueue("Emma");

        Console.WriteLine("\nQueue:");
        Console.WriteLine(queue.Dequeue()); // Peter
        Console.WriteLine(queue.Dequeue()); // Henrik

        // 6. PriorityQueue - Priority-based
        PriorityQueue<string, int> tasks =
            new PriorityQueue<string, int>();

        tasks.Enqueue("Low priority", 3);
        tasks.Enqueue("High priority", 1);
        tasks.Enqueue("Medium priority", 2);

        Console.WriteLine("\nPriorityQueue:");
        Console.WriteLine(tasks.Dequeue()); // High
        Console.WriteLine(tasks.Dequeue()); // Medium
    }
}
