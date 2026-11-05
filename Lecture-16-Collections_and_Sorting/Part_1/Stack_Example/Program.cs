using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> students = new Stack<string>();

        students.Push("Peter");
        students.Push("Henrik");
        students.Push("Sara");

        Console.WriteLine(students.Pop());
        Console.WriteLine(students.Pop());
        Console.WriteLine(students.Pop());
    }
}
