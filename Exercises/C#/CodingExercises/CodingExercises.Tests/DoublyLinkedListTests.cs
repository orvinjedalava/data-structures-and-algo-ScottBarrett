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

        [Theory]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })]
        [TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
        public void ReverseBetween_Tests(int[] values, int[] expectedValues)
        {
            // Arrange
            var list = CreateDoublyLinkedList(values);
            // Act
            var reversedList = DoublyLinkedListExercises.Reverse(list);

            // Assert
            var currentNode = reversedList.Head;
            foreach (var expectedValue in expectedValues)
            {
                Assert.That(currentNode, Is.Not.Null);
                Assert.That(currentNode!.Value, Is.EqualTo(expectedValue));
                currentNode = currentNode.Next;
            }
        }
    }
}