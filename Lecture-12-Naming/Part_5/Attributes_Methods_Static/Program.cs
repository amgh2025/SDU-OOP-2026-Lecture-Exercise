public class Student
{
    // Static field - shared by all Student objects
    private static int count = 0;

    // Instance field - each student has their own name
    private string name;

    // Constructor
    public Student(string name)
    {
        this.name = name;

        // Increase count whenever a Student is created
        count++;
    }

    // Instance method
    public void PrintName()
    {
        Console.WriteLine("Student name: " + name);
    }

    // Static method
    public static int GetCount()
    {
        return count;
    }
}

public class Test
{
    static void Main(string[] args)
    {
        Console.WriteLine("Initial count: "+ Student.GetCount());

        Student student1 = new Student("Peter");
        Student student2 = new Student("Mads");
        Student student3 = new Student("Sebastian");

        // Instance methods require objects
        student1.PrintName();
        student2.PrintName();
        student3.PrintName();

        // Static method uses the class name
        Console.WriteLine("Total students: "+ Student.GetCount());
    }
}
