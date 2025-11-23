using CodingExercises.Exercises;
using CodingExercises.Models;

namespace CodingExercises.Tests
{
    public class DoublyLinkedListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        public LinkedList CreateLinkedList(int[] values)
        {
            var list = new LinkedList(values[0]);
            for (int i = 1; i < values.Length; i++)
            {
                list.Push(values[i]);
            }

            return list;
        }

        public DoublyLinkedList CreateDoublyLinkedList(int[] values)
        {
            var list = new DoublyLinkedList(values[0]);
            for (int i = 1; i < values.Length; i++)
            {
                list.Push(values[i]);
            }

            return list;
        }

        [Theory]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, false)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, false)]
        [TestCase(new[] { 1, 2, 3, 2, 1 }, true)]
        public void PalindromeChecker_Tests(int[] values, bool expectedResult)
        {
            // Arrange
            var list = CreateDoublyLinkedList(values);

            // Act
            var isPalindrome = DoublyLinkedListExercises.PalindromeChecker(list);

            // Assert
            Assert.That(isPalindrome, Is.EqualTo(expectedResult));
        }
    }
}