public class Program
{
    public static void ZeroFirstHalf(int[] data)
    {
        for (int i = 0; i < data.Length / 2; i++)
        {
            data[i] = 0;
        }
    }

    public static void Main()
    {
        int[] numbers = { 10,20,30,40,50,60 };

        Console.WriteLine("Before:");
        Console.WriteLine(string.Join(", ", numbers));

        ZeroFirstHalf(numbers);

        Console.WriteLine("After:");
        Console.WriteLine(string.Join(", ", numbers));
    }
}
