
using System;

public class Program
{
    // Sort the array into increasing order
    public static int[] InsertionSort(int[] arr)
    {
        // Iterate over all items that may need relocation
        for (int itemsSorted = 1; itemsSorted < arr.Length; itemsSorted++)
        {
            // The item to be inserted
            int temp = arr[itemsSorted];

            // Start at the end of the sorted part
            int loc = itemsSorted - 1;

            // Move all items larger than temp one position right
            while (loc >= 0 && arr[loc] > temp)
            {
                arr[loc + 1] = arr[loc];

                // Move to the previous position
                loc = loc - 1;
            }

            // Insert temp into the correct position
            arr[loc + 1] = temp;
        }

        return arr;
    }

    public static void Main()
    {
        int[] numbers = { 8, 3, 5, 1, 4 };

        Console.WriteLine("Before sorting:");
        Console.WriteLine(string.Join(", ", numbers));

        InsertionSort(numbers);

        Console.WriteLine("After sorting:");
        Console.WriteLine(string.Join(", ", numbers));
    }
}
