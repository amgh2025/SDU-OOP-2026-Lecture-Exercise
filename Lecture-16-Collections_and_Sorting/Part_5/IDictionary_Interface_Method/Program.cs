
using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Program
{
    public static void Main()
    {
        // Interface and concrete implementation
        IDictionary<string, Person> people = new Dictionary<string, Person>();

        // 1. Add key-value pairs
        people.Add("P01", new Person("Peter", 25));
        people.Add("P02", new Person("Henrik", 30));
        people.Add("P03", new Person("Sara", 22));

        // 2. Access a value using a key
        Person person = people["P01"];
        Console.WriteLine(person.Name);

        // 3. Count
        Console.WriteLine("Count: " + people.Count);

        // 4. ContainsKey
        Console.WriteLine( "Contains P02: " + people.ContainsKey("P02"));

        // 5. Update an existing value
        people["P01"] = new Person("Peter", 26);

        Console.WriteLine("Updated age: " + people["P01"].Age);

        // 6. Remove a key-value pair
        people.Remove("P02");

        // 7. Print all elements
        foreach (KeyValuePair<string, Person> item in people)
        {
            Console.WriteLine(
                item.Key + " : " +
                item.Value.Name + " - " +
                item.Value.Age);
        }

        // 8. Clear all elements
        people.Clear();

        Console.WriteLine("Final count: " + people.Count);
    }
}
