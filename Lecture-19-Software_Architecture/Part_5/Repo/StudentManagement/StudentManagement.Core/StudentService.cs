using System.Collections.Generic;
using StudentManagement.Core.Interfaces;
using StudentManagement.Core.Models;

namespace StudentManagement.Core;

public class StudentService
{
    private IStudentRepository repository;

    public StudentService(IStudentRepository repository)
    {
        this.repository = repository;
    }

    public void AddStudent(string name, int grade)
    {
        Student student = new Student(name, grade);
        repository.AddStudent(student);
    }

    public List<Student> GetAllStudents()
    {
        return repository.GetAllStudents();
    }

    public List<Student> GetPassedStudents()
    {
        List<Student> passed = new List<Student>();

        foreach (Student student in repository.GetAllStudents())
        {
            if (student.Grade >= 50)
            {
                passed.Add(student);
            }
        }

        return passed;
    }
}
