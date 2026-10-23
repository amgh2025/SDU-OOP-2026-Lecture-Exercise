

public class Student
{
    private string name;

    public Student(string name)
    {
        // The parameter hides the instance field
        name = name;
        // Use this
        //this.name = name;
    }

    public void PrintName()
    {
        Console.WriteLine("Name: " + name);
    }
}

public class Test
{
    static void Main(string[] args)
    {
        Student student = new Student("Amir");
        student.PrintName();
    }
}
