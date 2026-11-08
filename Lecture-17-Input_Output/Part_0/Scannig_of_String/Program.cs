
using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        string input = "1,3.14,red,blue";

        // Split the string using comma as separator
        string[] inputs = input.Split(",");

        // Convert the individual parts
        long a = long.Parse(inputs[0]);

        double b = double.Parse(
            inputs[1],
            CultureInfo.InvariantCulture
        );

        string c = inputs[2];
        string d = inputs[3];

        // Print the extracted values
        Console.WriteLine(a + " " + b + " " + c + " " + d);
    }
}
