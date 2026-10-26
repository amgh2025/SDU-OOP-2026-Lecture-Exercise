
using System;

class Person
{
    public string CPR;

    public Person(string cpr)
    {
        CPR = cpr;
    }

    public override bool Equals(object obj)
    {
        // CASE 1: Unsafe casting

        // Problem 1: obj might not be a Person.
        // This can throw InvalidCastException.
        // Person p = (Person)obj;

        // Problem 2: obj might be null.
        // Accessing p.CPR would throw NullReferenceException.
        // return this.CPR == p.CPR;


        // CASE 2: Safe casting using 'is' (Fixed code)

        // Check whether obj is a Person before casting.
        // Also handles null safely.
        if (obj is Person p)
        {
            return this.CPR == p.CPR;
        }

        // Return false if obj is not a Person or is null.
        return false;
    }

    public override int GetHashCode()
    {
        return CPR.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("123456");
        Person p2 = new Person("123456");
        Person p3 = new Person("999999");

        Console.WriteLine(p1.Equals(p2));      // True
        Console.WriteLine(p1.Equals(p3));      // False
        Console.WriteLine(p1.Equals("Hello")); // False
        Console.WriteLine(p1.Equals(null));    // False
    }
}
