
public class Student
{
    // Instance field
    private string name = "Peter";

    // Static field
    private static int count = 10;

    // Example 1: Instance variable shadowing
    public void ShowName()
    {
        string name = "Mads";

        Console.WriteLine("Local name: " + name);
        Console.WriteLine("Instance name: " + this.name);
    }

    // Example 2: Static variable shadowing
    public static void ShowCount()
    {
        int count = 5;

        Console.WriteLine("Local count: " + count);
        Console.WriteLine("Static count: " + Student.count);
    }

    // Example 3: Field declared later in class
    public void ShowAge()
    {
        Console.WriteLine("Age: " + age);
    }

    private int age = 22;
}

public class Test
{
    static void Main(string[] args)
    {
        Student student = new Student();

        Console.WriteLine("--- Instance variables ---");
        student.ShowName();

        Console.WriteLine();

        Console.WriteLine("--- Static variables ---");
        Student.ShowCount();

        Console.WriteLine();

        Console.WriteLine("--- Declaration order ---");
        student.ShowAge();
    }
}
