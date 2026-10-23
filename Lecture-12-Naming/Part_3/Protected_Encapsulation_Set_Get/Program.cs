
public class Person
{
    // Protected field
    protected int age = 20;

    // Accessor method (Getter)
    public int GetAge()
    {
        return age;
    }

    // Mutator method (Setter)
    public void SetAge(int age)
    {
        if (age >= 0)
        {
            this.age = age;
        }
        else
        {
            Console.WriteLine("Invalid age!");
        }
    }
}

// Derived class
public class Student : Person
{
    public void ChangeAgeDirectly()
    {
        // Allowed because age is protected
        age = -10;
    }
}

public class Test
{
    static void Main(string[] args)
    {
        Person person = new Person();

        Console.WriteLine(person.GetAge());

        person.SetAge(25);
        Console.WriteLine(person.GetAge());

        person.SetAge(-10); // Rejected

        // ERROR: age is protected
        // person.age = 30;

        Student student = new Student();

        student.ChangeAgeDirectly();

        Console.WriteLine(student.GetAge());
    }
}
