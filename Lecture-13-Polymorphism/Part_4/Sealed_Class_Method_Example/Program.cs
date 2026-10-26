class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }

    public virtual void Introduce()
    {
        Console.WriteLine("I am a person: " + Name);
    }

    public virtual void ShowRole()
    {
        Console.WriteLine("I am a person.");
    }
}

class Student : Person
{
    public Student(string name) : base(name)
    {
    }

    // This method cannot be overridden again
    public sealed override void Introduce()
    {
        Console.WriteLine("I am a student: " + Name);
    }

    // This method can still be overridden
    public override void ShowRole()
    {
        Console.WriteLine("My role is Student.");
    }
}

class UniversityStudent : Student
{
    public UniversityStudent(string name) : base(name)
    {
    }

    // Allowed: ShowRole is not sealed
    public override void ShowRole()
    {
        Console.WriteLine("My role is University Student.");
    }

    // NOT ALLOWED: Introduce is sealed in Student
    // public override void Introduce()
    // {
    //     Console.WriteLine("University student");
    // }
}

// A sealed class cannot be inherited
sealed class Teacher : Person
{
    public Teacher(string name) : base(name)
    {
    }

    public override void Introduce()
    {
        Console.WriteLine("I am a teacher: " + Name);
    }
}

// NOT ALLOWED: Teacher is sealed
// class Professor : Teacher
// {
// }

class Program
{
    static void Main()
    {
        UniversityStudent student =new UniversityStudent("Peter");

        student.Introduce();
        student.ShowRole();

        Teacher teacher = new Teacher("Sarah");
        teacher.Introduce();
    }
}
