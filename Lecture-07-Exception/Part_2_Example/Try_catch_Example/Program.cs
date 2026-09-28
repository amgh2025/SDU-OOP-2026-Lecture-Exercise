void Work(int count)
{
    try
    {
        Console.WriteLine("A slice has to be " + (360 / count) + " degrees");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("No-one to eat the cake. Sad!");
    }
}

string[] children = new string[] {};

Work(children.Length);
