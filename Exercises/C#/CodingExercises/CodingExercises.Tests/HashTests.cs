using CodingExercises.Exercises;
using CodingExercises.Models;

namespace CodingExercises.Tests
{
    public class HashTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, false)]
        [TestCase(new[] { 1, 2, 3 }, new[] { 3, 4, 5 }, true)]
        [TestCase(new int[] { }, new[] { 1, 2, 3 }, false)]
        [TestCase(new[] { 1, 2, 3 }, new int[] { }, false)]
        [TestCase(new[] { -1, -2, -3 }, new[] { -3, 0, 1 }, true)]
        public void ItemInCommon_Tests(int[] array1, int[] array2, bool expected)
        {
            // Arrange
            var hashExercises = new HashExercises();

            // Act
            var result = hashExercises.ItemInCommon(array1, array2);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}