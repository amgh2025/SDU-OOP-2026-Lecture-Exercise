
Dog dog = new Dog();

class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal constructor");
    }
}

class Mammal : Animal
{
    public Mammal()
    {
        Console.WriteLine("Mammal constructor");
    }
}

class Dog : Mammal
{
    public Dog()
    {
        Console.WriteLine("Dog constructor");
    }
}
