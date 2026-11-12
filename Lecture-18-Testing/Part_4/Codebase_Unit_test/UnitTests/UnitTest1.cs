using Codebase;
using NUnit.Framework;

namespace UnitTests;

public class UtilTests
{
   [SetUp]
 public void Setup()
 {
 // Runs before each test. No setup needed yet.
 }
 [Test]
 public void Add_OneAndTwo_ReturnsThree()
 {
 // Arrange
 int a = 1;
 int b = 2;
 // Act
 int result = Util.Add(a, b);
 // Assert
 Assert.That(result, Is.EqualTo(3));
 }
}
