void Operation(int number, int divisor)
{
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
    Console.WriteLine(e);
}
catch (NegativeDivisorException ex)
{
    Console.WriteLine("Negative - Unable to do division.");
    Console.WriteLine(ex);
}


// Custom Exception
/*class NegativeDivisorException : Exception
{

}*/
