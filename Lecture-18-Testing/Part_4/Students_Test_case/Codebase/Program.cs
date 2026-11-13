using System;

namespace Codebase
{
    public class Program
    {
        public static void Main()
        {
            // Create Student objects
            Student student1 = new Student("Peter", 75);
            Student student2 = new Student("Sara", 30);
            Student student3 = new Student("Henrik", 50);

            // Call HasPassed() method
            Console.WriteLine(student1.Name + ": " + student1.HasPassed());

            Console.WriteLine(student2.Name + ": " + student2.HasPassed());

            Console.WriteLine(student3.Name + ": " + student3.HasPassed());
        }
    }
}
