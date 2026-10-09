

Dog dog = new Dog("Buddy", 3);

class Animal
{
    private string Name;

    public Animal(string name)
    {
        Name = name;
        Console.WriteLine("Animal constructor called");
    }
}

class Dog : Animal
{
    public int Age;

    public Dog(string name, int age) : base(name)
    {
        Age = age;
        Console.WriteLine("Dog constructor called");
    }


    /*public Dog(string name, int age)
    {
        Age = age;
        }*/
}
