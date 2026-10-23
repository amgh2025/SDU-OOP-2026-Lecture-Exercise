
public class Base
{
    public string PublicName = "public";
    private string PrivateName = "private";
    protected string ProtectedName = "protected";
    internal string InternalName = "internal";
}

public class Derived : Base
{
    public void Show()
    {
        // Accessible because Derived inherits from Base
        Console.WriteLine(PublicName);
        Console.WriteLine(ProtectedName);
        Console.WriteLine(InternalName);

        // ERROR: private members are not accessible
        // Console.WriteLine(PrivateName);
    }
}

public class Test
{
    static void Main(string[] args)
    {
        Base b = new Base();

        // Accessible from another class
        Console.WriteLine(b.PublicName);
        Console.WriteLine(b.InternalName);

        // ERROR: private member
        // Console.WriteLine(b.PrivateName);

        // ERROR: protected member
        // Console.WriteLine(b.ProtectedName);

        // Inheritance example
        Derived d = new Derived();
        d.Show();
    }
}
