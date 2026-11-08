public class Program
{
    public static void Main(string[] args)
    {
        List<string> products = new List<string>();
        products.Add("Milk");
        products.Add("Bread");
        products.Add("Eggs");

        Console.WriteLine("Initial Shopping List:");
        foreach (string product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("Total products: " + products.Count);

        products.Add("Butter");
        products.Remove("Bread");
        products[0] = "Cheese";

        Console.WriteLine();
        if (products.Contains("Eggs"))
        {
            Console.WriteLine("Eggs found");
        }
        else
        {
            Console.WriteLine("Eggs not found");
        }

        Console.WriteLine();
        Console.WriteLine("Final Shopping List:");
        foreach (string product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("Total products: " + products.Count);
    }
}
