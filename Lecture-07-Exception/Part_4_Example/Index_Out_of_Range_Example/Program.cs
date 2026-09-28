string GetStudent(string[] students, int index)
{
    return students[index];
}


string FindStudent(string[] students, int index)
{
    try
    {
        return GetStudent(students, index);
    }
    catch (IndexOutOfRangeException e)
    {
        Console.WriteLine("FindStudent caught the exception.");

        throw new Exception("The requested student does not exist.", e );
    }
}


void ShowStudent(string[] students, int index)
{
    try
    {
        string student = FindStudent(students, index);

        Console.WriteLine("Student: " + student);
    }
    catch (Exception e)
    {
        Console.WriteLine("Could not show the student.");
        Console.WriteLine("New error: " + e.Message);

        if (e.InnerException != null)
        {
            Console.WriteLine(
                "Original error: " + e.InnerException.Message
            );
        }
    }
}


string[] students = { "Anna", "Peter", "Maria" };

ShowStudent(students, 1);

Console.WriteLine("----------------");

ShowStudent(students, 5);
