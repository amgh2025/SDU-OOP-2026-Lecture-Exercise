
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

    // Defines how two Person objects are compared
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
        return Name + " (" + Age + ")";
    }
}

public class Program
{
    public static void PrintList(List<Person> persons)
    {
        Console.Write("List<Person> [");

        for (int i = 0; i < persons.Count; i++)
        {
            if (i > 0)
            {
                Console.Write(", ");
            }

            Console.Write(persons[i]);
        }

        Console.WriteLine("]");
    }

    public static void Main()
    {
        List<Person> persons = new List<Person>();

        persons.Add(new Person("Peter", 72));
        persons.Add(new Person("Henrik", 4));
        persons.Add(new Person("Sara", 17));

        Console.WriteLine("Before Sorting:");
        PrintList(persons);

        // Uses Person.CompareTo() automatically
        persons.Sort();

        Console.WriteLine("\nAfter Sorting:");
        PrintList(persons);
    }
}
