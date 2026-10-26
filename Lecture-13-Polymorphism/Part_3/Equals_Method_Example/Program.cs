class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override bool Equals(object obj)
    {
        // Check if obj is a Person
        if (obj is Person other)
        {
            return Name == other.Name && Age == other.Age;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age);
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("Peter", 20);
        Person p2 = new Person("Peter", 20);
        Person p3 = new Person("Sarah", 22);

        Person p4 = p1;

        // Compare object references
        Console.WriteLine(Object.ReferenceEquals(p1, p2));

        // Compare object values
        Console.WriteLine(p1.Equals(p2));
        Console.WriteLine(p1.Equals(p3));

        // Compare an object with itself
        Console.WriteLine(p1.Equals(p1));

        // Compare with a different type
        Console.WriteLine(p1.Equals("Peter"));

        //Compare for copy refrerence
        Console.WriteLine(p1.Equals(p4));
    }
}
