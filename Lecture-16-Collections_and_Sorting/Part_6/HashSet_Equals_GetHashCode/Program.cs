
using System;
using System.Collections.Generic;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    // Two students are equal if their IDs are equal
    public override bool Equals(object? obj)
    {
        if (obj is Student other)
        {
            return Id == other.Id;
        }

        return false;
    }

    // Equal students must have the same hash code
    public override int GetHashCode()
    {
        return Id * 31;
    }

    public override string ToString()
    {
        return Name + " (ID: " + Id + ")";
    }
}

public class Program
{
    public static void Main()
    {
        Student s1 = new Student(1001, "Peter");
        Student s2 = new Student(1001, "Sara");
        Student s3 = new Student(1002, "Henrik");

        // Create a HashSet
        HashSet<Student> students = new HashSet<Student>();

        // Add students
        Console.WriteLine(students.Add(s1));
        Console.WriteLine(students.Add(s2));
        Console.WriteLine(students.Add(s3));

        // Print the number of students
        Console.WriteLine("Count: " + students.Count);

        // Print all students
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }

        // Compare students
        Console.WriteLine("s1 equals s2: " + s1.Equals(s2));

        // Compare hash codes
        Console.WriteLine("Same hash code: " + (s1.GetHashCode() == s2.GetHashCode()));

        Console.WriteLine("Hash Code s1: " + s1.GetHashCode());
        Console.WriteLine("Hash Code s2: " + s2.GetHashCode());
        Console.WriteLine("Hash Code s3: " + s3.GetHashCode());


        // Check whether the HashSet contains s2
        Console.WriteLine("Contains s2: " +students.Contains(s2));
    }
}
