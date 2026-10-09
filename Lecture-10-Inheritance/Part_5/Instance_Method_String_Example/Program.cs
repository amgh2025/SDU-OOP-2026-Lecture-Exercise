

// ==================================================
// Example 1: Replace()
// ==================================================

Console.WriteLine("===== Example 1: Replace() =====");

string text1 = "I like Java. Java is popular.";

string replaced = text1.Replace("Java", "C#");

Console.WriteLine("Original: " + text1);
Console.WriteLine("Replaced: " + replaced);


// ==================================================
// Example 2: Replace()
// ==================================================

Console.WriteLine("\n===== Example 2: Immutability =====");

string text2 = "Hello World";

text2.Replace("World", "Students");

Console.WriteLine("Without assignment: " + text2);

text2 = text2.Replace("World", "Students");

Console.WriteLine("With assignment: " + text2);


// ==================================================
// Example 3: Split() Using Comma
// ==================================================

Console.WriteLine("\n===== Example 3: Split() =====");

string text3 = "Apple,Banana,Orange";

string[] fruits = text3.Split(",");

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}


// ==================================================
// Example 4: Split() Using Space
// ==================================================

Console.WriteLine("\n===== Example 4: Split() with Space =====");

string sentence = "C# is easy to learn";

string[] words = sentence.Split(" ");

Console.WriteLine("Number of words: " + words.Length);
Console.WriteLine("First word: " + words[0]);
Console.WriteLine("Third word: " + words[2]);


// ==================================================
// Example 5: Split() with Empty Strings
// ==================================================

Console.WriteLine("\n===== Example 5: Empty Strings =====");

string text5 = "Apple,,Orange";

string[] items = text5.Split(",");

Console.WriteLine("Number of elements: " + items.Length);

foreach (string item in items)
{
    Console.WriteLine("[" + item + "]");
}


// ==================================================
// Example 6: Equals()
// ==================================================

Console.WriteLine("\n===== Example 6: Equals() =====");

string s1 = "Hello";
string s2 = "Hello";
string s3 = "hello";

Console.WriteLine("s1.Equals(s2): " + s1.Equals(s2));
Console.WriteLine("s1.Equals(s3): " + s1.Equals(s3));




// ==================================================
// Example 7: Contains()
// ==================================================

Console.WriteLine("\n===== Example 8: Contains() =====");

string text8 = "Welcome to C# programming";

Console.WriteLine("Contains C#: " + text8.Contains("C#"));
Console.WriteLine("Contains Java: " + text8.Contains("Java"));
Console.WriteLine("Contains program: " + text8.Contains("program"));
Console.WriteLine("Contains program: " + text8.Contains("Program"));
Console.WriteLine("Contains c#: " + text8.Contains("c#"));
