int Divide(int a, int b)
{
    return a / b;
}

Console.WriteLine("Program started.");

try
{
    int result = Divide(20, 0);
    Console.WriteLine("Result: " + result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero.");
}
finally
{
    Console.WriteLine("Program finished.");
}
