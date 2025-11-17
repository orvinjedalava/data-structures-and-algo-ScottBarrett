using CodingExercises.Exercises;
using CodingExercises.Models;

namespace CodingExercises.Tests
{
    public class LinkedListTests
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



        [Theory]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, 4)]
        [TestCase(new[] { 1 }, 1)]
        [TestCase(new[] { 1, 2 }, 2)]
        [TestCase(new[] { 10, 20, 30 }, 20)]
        public void FindMiddleNode_Tests(int[] values, int expectedValue)
        {
            // Arrange
            var list = CreateLinkedList(values);

            // Act
            var middleNode = LinkedListExercises.FindMiddleNode(list);

            // Assert
            Assert.That(middleNode, Is.Not.Null);
            Assert.That(middleNode.Value, Is.EqualTo(expectedValue));
        }
    }
}