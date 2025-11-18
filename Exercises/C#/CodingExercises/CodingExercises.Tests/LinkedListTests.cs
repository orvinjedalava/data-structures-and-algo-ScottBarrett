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

        public LinkedList CreateLinkedListWithLoop(int[] values)
        {
            var listWithLoop = CreateLinkedList(new[] { 1, 2, 3, 4, 5 });
            // Creating a loop for testing: connecting the last node to the second node
            var tail = listWithLoop.Head;
            while (tail.Next != null)
            {
                tail = tail.Next;
            }
            tail.Next = listWithLoop.Head.Next; // Creating loop
            return listWithLoop;
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

        [Test]
        public void HasLoop_Tests()
        {
            // Arrange
            var listWithLoop = CreateLinkedListWithLoop(new[] { 1, 2, 3, 4, 5 });
            var listWithoutLoop = CreateLinkedList(new[] { 1, 2, 3, 4, 5 });

            // Act
            var hasLoop1 = LinkedListExercises.HasLoop(listWithLoop);
            var hasLoop2 = LinkedListExercises.HasLoop(listWithoutLoop);

            // Assert
            Assert.That(hasLoop1, Is.True);
            Assert.That(hasLoop2, Is.False);
        }

        [Theory]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 1, 5)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 3, 3)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 5, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 6, null)]
        public void KthNodeFromTheEnd_Tests(int[] values, int k, int? expectedValue)
        {
            // Arrange
            var list = CreateLinkedList(values);

            // Act & Assert
            var node = LinkedListExercises.KthNodeFromTheEnd(list, k);
            Assert.That(node?.Value, Is.EqualTo(expectedValue));
        }
    }
}