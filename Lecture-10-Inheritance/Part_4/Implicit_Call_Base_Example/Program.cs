using System;

Animal animal = new Animal();
Dog dog = new Dog();

class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal constructor called");
    }
}

/*class Animal
{

}*/

class Dog : Animal
{
    public Dog()
    {
        Console.WriteLine("Dog constructor called");
    }
}
