
using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine( "The following environment variables are defined:");

        // Get all environment variables
        IDictionary variables =Environment.GetEnvironmentVariables();

        // Print each key and value
        foreach (DictionaryEntry de in variables)
        {
            Console.WriteLine( "- '" + de.Key + "': '" + de.Value + "'");
        }
    }
}
