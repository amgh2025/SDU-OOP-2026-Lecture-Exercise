using System.Collections.Generic;
using StudentManagement.Core.Models;

namespace StudentManagement.Core.Interfaces;

public interface IStudentRepository
{
    void AddStudent(Student student);
    List<Student> GetAllStudents();
}
