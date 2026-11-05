using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> students = new Queue<string>();

        students.Enqueue("Peter");
        students.Enqueue("Henrik");
        students.Enqueue("Sara");

        Console.WriteLine(students.Dequeue());
        Console.WriteLine(students.Dequeue());
        Console.WriteLine(students.Dequeue());
    }
}
