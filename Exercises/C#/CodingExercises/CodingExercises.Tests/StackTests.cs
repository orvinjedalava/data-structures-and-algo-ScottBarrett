using CodingExercises.Exercises;
using CodingExercises.Models;

namespace CodingExercises.Tests
{
    public class StackTests
    {
        // Implement stack tests here
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase("hello", "olleh")]
        [TestCase("Stack", "kcatS")]
        [TestCase("12345", "54321")]
        public void ReverseString_Tests(string input, string expectedOutput)
        {
            // Act
            var reversed = StackExercises.ReverseString(input);

            // Assert
            Assert.That(reversed, Is.EqualTo(expectedOutput));
        }
    }
}