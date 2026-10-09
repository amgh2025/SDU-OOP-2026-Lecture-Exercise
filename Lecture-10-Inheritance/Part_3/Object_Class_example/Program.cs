Person p1 = new Person("Peter", 20);
Person p2 = new Person("Sara", 22);
Person p3 = p1;

Console.WriteLine("=== ToString() ===");
Console.WriteLine(p1.ToString());

Console.WriteLine("=== GetType() ===");
Console.WriteLine(p1.GetType());

Console.WriteLine("=== Equals() ===");
Console.WriteLine(p1.Equals(p2));
Console.WriteLine(p1.Equals(p3));

Console.WriteLine("=== GetHashCode() ===");
Console.WriteLine(p1.GetHashCode());

Console.WriteLine("Parent class of Person is :");
Console.WriteLine(typeof(Person).BaseType);




public class Person
{
    public string name;
    public int age;

    public Person(string nameValue, int ageValue)
    {
        name = nameValue;
        age = ageValue;
    }
}
