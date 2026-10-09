Student student = new Student();
GraphicsStudent graphicsStudent = new GraphicsStudent();

Console.WriteLine("Student:");
student.PrintAbilities();

Console.WriteLine("\nGraphicsStudent:");
graphicsStudent.PrintAbilities();


// Parent Class
public class Student
{
    public virtual void PrintAbilities()
    {
        Console.WriteLine("Learning");
    }
}


// Child Class
public class GraphicsStudent : Student
{
    public override void PrintAbilities()
    {
        base.PrintAbilities();
        Console.WriteLine("Graphics");
    }
}
