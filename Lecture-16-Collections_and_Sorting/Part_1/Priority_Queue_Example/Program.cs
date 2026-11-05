using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        PriorityQueue<string, int> patients =new PriorityQueue<string, int>();

        patients.Enqueue("Peter", 3);
        patients.Enqueue("Henrik", 1);
        patients.Enqueue("Sara", 2);

        Console.WriteLine(patients.Dequeue());
        Console.WriteLine(patients.Dequeue());
        Console.WriteLine(patients.Dequeue());
    }
}
