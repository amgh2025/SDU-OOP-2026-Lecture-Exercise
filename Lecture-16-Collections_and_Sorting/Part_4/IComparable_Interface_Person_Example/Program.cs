
using System;
using System.Collections.Generic;

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Compare two Person objects by age
    public int CompareTo(Person? other)
    {
        if (other == null)
        {
            return 1;
        }

        return Age.CompareTo(other.Age);
    }

    public override string ToString()
    {
        return Name + " - Age: " + Age;
    }
}

class Program
{
    static void Main()
    {
        Person peter = new Person("Peter", 25);
        Person henrik = new Person("Henrik", 20);
        Person sara = new Person("Sara", 25);

        Console.WriteLine("Compare Peter and Henrik:");
        Console.WriteLine(peter.CompareTo(henrik));

        Console.WriteLine("Compare Henrik and Peter:");
        Console.WriteLine(henrik.CompareTo(peter));

        Console.WriteLine("Compare Peter and Sara:");
        Console.WriteLine(peter.CompareTo(sara));

        List<Person> people = new List<Person>();

        people.Add(peter);
        people.Add(henrik);
        people.Add(sara);

        people.Sort();

        Console.WriteLine("\nAfter Sorting:");

        foreach (Person person in people)
        {
            Console.WriteLine(person);
        }
    }
}
