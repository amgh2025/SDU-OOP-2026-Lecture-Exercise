using System;
using StudentManagement.Core;
using StudentManagement.Core.Models;
using StudentManagement.Data;

namespace StudentManagement.ConsoleApp;

public class Program
{
    public static void Main()
    {
        StudentRepository repository = new StudentRepository();
        StudentService service = new StudentService(repository);

        service.AddStudent("Peter", 80);
        service.AddStudent("Sara", 95);
        service.AddStudent("Henrik", 40);
        service.AddStudent("Emma", 60);

        Console.WriteLine("All Students:");
        foreach (Student student in service.GetAllStudents())
        {
            Console.WriteLine(student.Name + " - " + student.Grade);
        }

        Console.WriteLine("\nPassed Students:");
        foreach (Student student in service.GetPassedStudents())
        {
            Console.WriteLine(student.Name + " - " + student.Grade);
        }
    }
}
