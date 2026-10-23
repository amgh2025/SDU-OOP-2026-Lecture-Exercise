
public class Person
{
    //private string name;
    private string name = "Peter";


    public void PrintName()
    {
        Console.WriteLine(name);
    }
}

public class Test
{
    static void Main(string[] args)
    {
        Person person = new Person();

        person.PrintName();

        // Console.WriteLine(person.name); // Error!
    }
}
