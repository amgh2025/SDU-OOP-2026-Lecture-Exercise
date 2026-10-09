
Dog dog1 = new Dog();
Dog dog2 = new Dog("Buddy");

class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal default constructor");
    }

    public Animal(string name)
    {
        Console.WriteLine("Animal constructor: " + name);
    }
}

class Dog : Animal
{
    public Dog()
    {
        Console.WriteLine("Dog default constructor");
    }

    public Dog(string name) : base(name)
    {
        Console.WriteLine("Dog constructor");
    }
}
