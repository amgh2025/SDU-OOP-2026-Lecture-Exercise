class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }

    public virtual void Introduce()
    {
        Console.WriteLine("My name is " + Name);
    }
}

class Student : Person
{
    public int StudentId;
    public Student(string name, int studentId): base(name)
    {
        StudentId = studentId;
    }

    public override void Introduce()
    {
        Console.WriteLine("I am student " + Name);
    }

    public void Study()
    {
        Console.WriteLine(Name + " is studying.");
    }
}

class Teacher : Person
{
    public Teacher(string name) : base(name)
    {
    }

    public void Teach()
    {
        Console.WriteLine(Name + " is teaching.");
    }
}

class Program
{
    static void Main()
    {
        // 1. Upcasting (Implicit Casting)
        Student student = new Student("Peter", 101);
        Person person = student;

        person.Introduce();

        // 2. Downcasting (Explicit Casting)
        Student studentAgain = (Student)person;
        studentAgain.Study();

        // 3. Checking the type with 'is'
        Person anotherPerson = new Teacher("Sarah");

        if (anotherPerson is Student)
        {
            Student s = (Student)anotherPerson;
            s.Study();
        }
        else
        {
            Console.WriteLine("This person is not a student.");
        }

        // 4. Pattern Matching
        if (person is Student s2)
        {
            Console.WriteLine("Student ID: " + s2.StudentId);
        }
    }
}
