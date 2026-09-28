double Divide(double a, double b)
{
    if (b == 0)
    {
        throw new Exception("B is equal to 0");
    }

    return a / b;
}

try
{
    double result = Divide(10, 0);
    Console.WriteLine("Result: " + result);
}
catch (Exception e)
{
    Console.WriteLine("Something went wrong!");
    Console.WriteLine(e.Message);
}
