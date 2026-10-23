public class Person
{
    // Internal field
    internal string name = "Peter";

    // Accessor method (Getter)
    public string GetName()
    {
        return name;
    }

    // Mutator method (Setter)
    public void SetName(string name)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            this.name = name;
        }
        else
        {
            Console.WriteLine("Invalid name!");
        }
    }
}

public class Test
{
    static void Main(string[] args)
    {
        Person person = new Person();

        // 1. Read through getter
        Console.WriteLine(person.GetName());

        // 2. Change through setter
        person.SetName("Mads");
        Console.WriteLine(person.GetName());

        // 3. Invalid value through setter
        person.SetName("");

        // 4. Direct access to internal field

        Console.WriteLine("Direct access to internal field");
        person.name = "";
        Console.WriteLine(person.name);


        // 5. Bypass validation
        Console.WriteLine("Bypass validation");
        person.name = "";
        Console.WriteLine("Name: " + person.GetName());
    }
}
