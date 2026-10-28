// Interface defines a contract
public interface ILockable
{
    void Lock();
    void Unlock();
}

// House implements ILockable
public class House : ILockable
{
    public  void Lock()
    {
        Console.WriteLine("Locking the house!");
    }

    public void Unlock()
    {
        Console.WriteLine("Unlocking the house!");
    }
}

// Car also implements ILockable
public class Car : ILockable
{
    public void Lock()
    {
        Console.WriteLine("Locking the car!");
    }

    public void Unlock()
    {
        Console.WriteLine("Unlocking the car!");
    }
}

class Program
{
    static void Main()
    {
        ILockable item1 = new House();
        ILockable item2 = new Car();

        item1.Lock();
        item2.Lock();

        item1.Unlock();
        item2.Unlock();
    }
}
