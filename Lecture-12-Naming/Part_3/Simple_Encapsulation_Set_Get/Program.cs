
public class Person
{
    // Private instance fields
    private string firstName = "Henning";
    private string lastName = "Hansen";
    private bool atHome = true;
    private string title = "Mr.";

    // ACCESSOR METHODS (Getters)

    public string GetFirstName()
    {
        return firstName;
    }

    public string GetLastName()
    {
        return lastName;
    }

    public bool IsAtHome()
    {
        return atHome;
    }

    public string GetTitle()
    {
        return title;
    }

    // MUTATOR METHODS (Setters)

    public void SetFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public void SetLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public void SetAtHome(bool atHome)
    {
        this.atHome = atHome;
    }

    // COMPLEX ENCAPSULATION
    // Validate the value before assigning it

    public void SetTitle(string title)
    {
        if (title == null)
        {
            this.title = "(untitled)";
        }
        else
        {
            this.title = title;
        }
    }
}

public class Test
{
    static void Main(string[] args)
    {
        Person person = new Person();

        // 1. ACCESSOR METHODS
        Console.WriteLine("--- Initial values ---");

        Console.WriteLine(person.GetFirstName());
        Console.WriteLine(person.GetLastName());
        Console.WriteLine(person.IsAtHome());
        Console.WriteLine(person.GetTitle());

        // 2. MUTATOR METHODS
        Console.WriteLine("\n--- Changing values ---");

        person.SetFirstName("Peter");
        person.SetLastName("Mads");
        person.SetAtHome(false);

        Console.WriteLine(person.GetFirstName());
        Console.WriteLine(person.GetLastName());
        Console.WriteLine(person.IsAtHome());

        // 3. COMPLEX ENCAPSULATION
        Console.WriteLine("\n--- Validation ---");

        person.SetTitle(null);
        // Test title
        //person.SetTitle("OOP");

        Console.WriteLine(person.GetTitle());

        // ERROR: Cannot directly access private fields
        // person.firstName = "Ali";
    }
}
