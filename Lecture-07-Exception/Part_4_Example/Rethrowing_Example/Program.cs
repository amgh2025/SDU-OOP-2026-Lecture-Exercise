int Work(int dividend, int divisor)
{
    return dividend / divisor;
}

int Intermediary(int dividend, int divisor)
{
    try
    {
        return Work(dividend, divisor);
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine("Oh, shit!");

        throw new Exception("Divisor was invalid.", e);
    }
}

int[] divisors = { 2, 1, 0, -1, -2 };

foreach (int divisor in divisors)
{
    Console.WriteLine(Intermediary(42, divisor));
}


/*foreach (int divisor in divisors)
{
    try
    {
        Console.WriteLine(Intermediary(42, divisor));
    }
    catch (Exception e)
    {
        Console.WriteLine("Error: " + e.Message);
    }
}*/
