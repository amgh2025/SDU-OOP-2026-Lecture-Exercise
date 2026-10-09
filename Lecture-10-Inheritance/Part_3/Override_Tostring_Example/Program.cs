Student s1 = new Student("Ali", 20);

Console.WriteLine(s1);
Console.WriteLine(s1.ToString());


public class Student
{
    public string name;
    public int age;

    public Student(string nameValue, int ageValue)
    {
        name = nameValue;
        age = ageValue;
    }
    /*public override string ToString()
    {
        return "Name: " + name + ", Age: " + age;
        }*/
}
