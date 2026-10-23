
// Base class
public class Person
{
    protected string name;
    protected int age;

    // Constructor 1
    public Person(string name)
    {
        this.name = name;
        Console.WriteLine("Person Constructor 1");
    }

    // Constructor 2
    public Person(string name, int age) : this(name)
    {
        this.age = age;
        Console.WriteLine("Person Constructor 2");
    }

    public void PrintInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

// Derived class
public class Student : Person
{
    private string program;

    // Constructor 1
    public Student() : this("Unknown", 18, "Software Engineering")
    {
        Console.WriteLine("Student Constructor 1");
    }

    // Constructor 2
    public Student(string name, int age, string program)
        : base(name, age)
    {
        this.program = program;
        Console.WriteLine("Student Constructor 2");
    }

    public void PrintStudentInfo()
    {
        PrintInfo();
        Console.WriteLine("Program: " + program);
    }
}

public class Test
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Student 1 ---");

        Student student1 = new Student();
        student1.PrintStudentInfo();

        Console.WriteLine();

        Console.WriteLine("--- Student 2 ---");

        Student student2 =new Student("Peter", 25, "Computer Science");

        student2.PrintStudentInfo();
    }
}
