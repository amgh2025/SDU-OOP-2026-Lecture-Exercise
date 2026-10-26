class Program
{
    static void Main()
    {
        string s1 = new string("Hello".ToCharArray());
        string s2 = new string("Hello".ToCharArray());

        Console.WriteLine(s1 == s2);
        Console.WriteLine(s1.Equals(s2));
        Console.WriteLine(Object.ReferenceEquals(s1, s2));

        // Both variables refer to the same object
        string s3 = s1;

        Console.WriteLine(Object.ReferenceEquals(s1, s3));
    }
}
