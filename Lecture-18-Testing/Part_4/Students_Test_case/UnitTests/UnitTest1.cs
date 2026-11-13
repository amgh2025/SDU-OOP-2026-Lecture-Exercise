using System;
using Codebase;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void Score75_ShouldPass()
        {
            // Arrange
            Student student = new Student("Peter", 75);

            // Act
            bool result = student.HasPassed();

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void Score30_ShouldFail()
        {
            // Arrange
            Student student = new Student("Sara", 30);

            // Act
            bool result = student.HasPassed();

            // Assert
            Assert.That(result, Is.False);
            //Assert.That(result, Is.True);
        }

        [Test]
        public void Score50_ShouldPass()
        {
            // Arrange
            Student student = new Student("Henrik", 50);

            // Act
            bool result = student.HasPassed();

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void Score49_ShouldFail()
        {
            // Arrange
            Student student = new Student("Peter", 49);

            // Act
            bool result = student.HasPassed();

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void NegativeScore_ShouldThrowException()
        {
            // Act and Assert
            Assert.Throws<ArgumentException>(() => new Student("Sara", -10));
        }

        [Test]
        public void ScoreAbove100_ShouldThrowException()
        {
            // Act and Assert
            Assert.Throws<ArgumentException>(() => new Student("Henrik", 110));
        }


        [Test]
        public void TestIsNull()
        {
            // Arrange
            Student? student = null;

            // Assert
            Assert.That(student, Is.Null);
        }

        [Test]
        public void TestIsInstanceOf()
        {
            // Arrange
            Student student = new Student("Sara", 80);

            // Assert
            Assert.That(student, Is.InstanceOf<Student>());
        }





        // TC-07: Minimum valid score
        [Test]
        public void Score0_ShouldFail()
        {
            Student student = new Student("Peter", 0);

            Assert.That(student.HasPassed(), Is.False);
        }

        // TC-08: Maximum valid score
        [Test]
        public void Score100_ShouldPass()
        {
            Student student = new Student("Sara", 100);

            Assert.That(student.HasPassed(), Is.True);
        }

        // TC-09: Just above passing boundary
        [Test]
        public void Score51_ShouldPass()
        {
            Student student = new Student("Henrik", 51);

            Assert.That(student.HasPassed(), Is.True);
        }

        // TC-10: Score above maximum
        [Test]
        public void Score101_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Student("Peter", 101));
        }

        // TC-11: Score below minimum
        [Test]
        public void ScoreMinus1_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Student("Sara", -1));
        }
        // TC-12: Check student name
        [Test]
        public void StudentName_ShouldBePeter()
        {
            Student student = new Student("Peter", 75);

            Assert.That(student.Name, Is.EqualTo("Peter"));
        }

        // TC-13: Check object is not null
        [Test]
        public void StudentObject_ShouldNotBeNull()
        {
            Student student = new Student("Peter", 75);

            Assert.That(student, Is.Not.Null);
        }

        // TC-14: Check object type
        [Test]
        public void StudentObject_ShouldBeStudentType()
        {
            Student student = new Student("Sara", 80);

            Assert.That(student, Is.InstanceOf<Student>());
        }

        // TC-15: Change score after creation
        [Test]
        public void ChangeScore_ShouldChangePassResult()
        {
            // Arrange
            Student student = new Student("Peter", 40);

            Assert.That(student.HasPassed(), Is.False);

            // Act
            student.Score = 60;

            // Assert
            Assert.That(student.HasPassed(), Is.True);
        }

        // TC-16: Parameterized test
        [TestCase(0, false)]
        [TestCase(20, false)]
        [TestCase(49, false)]
        [TestCase(50, true)]
        [TestCase(75, true)]
        [TestCase(100, true)]
        public void DifferentScores_ShouldReturnCorrectResult(
            int score, bool expected)
        {
            // Arrange
            Student student = new Student("Peter", score);

            // Act
            bool result = student.HasPassed();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
