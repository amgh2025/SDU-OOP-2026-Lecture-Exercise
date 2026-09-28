void ReadData(bool problem)
{
    try
    {
        Console.WriteLine("Opening resource...");

        if (problem)
        {
            throw new Exception("Something went wrong!");
        }

        Console.WriteLine("Using resource...");
    }
    catch (Exception e)
    {
        Console.WriteLine("Error: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Closing resource...");
    }
}

ReadData(false);

Console.WriteLine("----------------");

ReadData(true);
