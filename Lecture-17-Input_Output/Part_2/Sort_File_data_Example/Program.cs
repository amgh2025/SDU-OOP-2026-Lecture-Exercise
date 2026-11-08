
using System;
using System.IO;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    public override string ToString()
    {
        return Name + " - Grade: " + Grade;
    }
}

public class Program
{
    public static void Main()
    {
        string filename = "grades.txt";

        // STEP 1: Write student grades to a file
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Peter,10");
            writer.WriteLine("Sara,12");
            writer.WriteLine("Henrik,7");
            writer.WriteLine("Emma,10");
            writer.WriteLine("Lucas,4");
        }

        Console.WriteLine("File created!");

        // STEP 2: Create a List of students
        List<Student> students = new List<Student>();

        // STEP 3: Read the file using StreamReader
        using (StreamReader reader = new StreamReader(filename))
        {
            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                // Split name and grade
                string[] parts = line.Split(',');

                string name = parts[0];
                int grade = int.Parse(parts[1]);

                // Create a Student object
                Student student = new Student(name, grade);

                // Add student to the List
                students.Add(student);
            }
        }

        // STEP 4: Display students before sorting
        Console.WriteLine("\nBefore Sorting:");

        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }

        // STEP 5: Sort students by grade (ascending)
        students.Sort((a, b) => a.Grade.CompareTo(b.Grade));

        // STEP 6: Display students after sorting
        Console.WriteLine("\nAfter Sorting by Grade:");

        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}
