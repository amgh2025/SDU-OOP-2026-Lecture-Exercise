void Operation(int number, int divisor)
{
    if (divisor < 0)
    {
        throw new NegativeDivisorException();
    }

    int result = number / divisor;

    Console.WriteLine("Result: " + result);
}

try
{
    Operation(1, 0);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Unable to do division.");
    Console.WriteLine(e.Message);
}
catch (NegativeDivisorException e)
{
    Console.WriteLine("The divisor cannot be negative.");
    Console.WriteLine(e.Message);
}


// Custom Exception
class NegativeDivisorException : Exception
{
}
