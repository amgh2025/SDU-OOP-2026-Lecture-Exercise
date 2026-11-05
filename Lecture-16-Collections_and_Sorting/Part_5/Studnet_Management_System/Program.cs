
using System;
using System.Collections.Generic;

// Student class
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> Grades { get; set; }

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
        Grades = new List<int>();
    }

    public void AddGrade(int grade)
    {
        Grades.Add(grade);
    }

    public double GetAverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0;
        }

        int total = 0;

        foreach (int grade in Grades)
        {
            total += grade;
        }

        return (double)total / Grades.Count;
    }

    public void PrintInfo()
    {
        Console.WriteLine(
            Id + " - " + Name +
            " - Age: " + Age +
            " - Average: " +
            GetAverageGrade().ToString("F2"));
    }
}

// Student management class
public class StudentManager
{
    public Dictionary<int, Student> Students { get; set; }

    public StudentManager()
    {
        Students = new Dictionary<int, Student>();
    }

    // Add a student
    public void AddStudent(Student student)
    {
        if (Students.ContainsKey(student.Id))
        {
            Console.WriteLine("Student ID already exists!");
            return;
        }

        Students.Add(student.Id, student);
        Console.WriteLine(student.Name + " added.");
    }

    // Find a student
    public Student FindStudent(int id)
    {
        if (Students.TryGetValue(id, out Student student))
        {
            return student;
        }

        return null;
    }

    // Update student age
    public void UpdateAge(int id, int newAge)
    {
        Student student = FindStudent(id);

        if (student != null)
        {
            student.Age = newAge;
            Console.WriteLine("Age updated.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    // Remove a student
    public void RemoveStudent(int id)
    {
        if (Students.Remove(id))
        {
            Console.WriteLine("Student removed.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    // Print all students
    public void PrintAllStudents()
    {
        foreach (KeyValuePair<int, Student> item in Students)
        {
            item.Value.PrintInfo();
        }
    }
}

public class Program
{
    public static void Main()
    {
        StudentManager manager = new StudentManager();

        // Create students
        Student peter = new Student(101, "Peter", 22);
        Student henrik = new Student(102, "Henrik", 21);
        Student sara = new Student(103, "Sara", 23);

        // Add grades
        peter.AddGrade(80);
        peter.AddGrade(90);

        henrik.AddGrade(70);
        henrik.AddGrade(80);

        sara.AddGrade(95);
        sara.AddGrade(85);

        // Add students to Dictionary
        manager.AddStudent(peter);
        manager.AddStudent(henrik);
        manager.AddStudent(sara);

        // Try adding a duplicate ID
        manager.AddStudent(
            new Student(101, "Emma", 20));

        Console.WriteLine("\nAll Students:");
        manager.PrintAllStudents();

        // Find student by ID
        Console.WriteLine("\nFind Student 102:");

        Student found = manager.FindStudent(102);

        if (found != null)
        {
            found.PrintInfo();
        }

        // Update student information
        manager.UpdateAge(101, 24);

        // Remove a student
        manager.RemoveStudent(103);

        Console.WriteLine("\nFinal Students:");
        manager.PrintAllStudents();

        Console.WriteLine("\nTotal Students: " + manager.Students.Count);
    }
}
