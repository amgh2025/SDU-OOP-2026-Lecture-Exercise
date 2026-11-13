using System;
namespace Codebase
{
    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Student(string name, int score)
        {
            if (score < 0 || score > 100) throw new ArgumentException("Score must be between 0 and 100");
            Name = name;
            Score = score;
        }

        public bool HasPassed()
        {
            //return Score >= 50;
            return Score >= 50;
        }
    }
}
