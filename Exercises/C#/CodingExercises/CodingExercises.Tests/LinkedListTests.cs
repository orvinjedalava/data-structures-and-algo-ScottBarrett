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

        [Theory]
        [TestCase(new[] { 1, 2, 2, 3, 4, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
        [TestCase(new[] { 1, 1, 1, 1, 1 }, new[] { 1 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
        [TestCase(new[] { 4, 3, 2, 1, 1, 2, 3, 4 }, new[] { 4, 3, 2, 1 })]
        public void RemoveDuplicates_Tests(int[] values, int[] expectedValues)
        {
            // Arrange
            var list = CreateLinkedList(values);
            // Act
            LinkedListExercises.RemoveDuplicates(list);
            // Assert
            //var expectedValues = new[] { 1, 2, 3, 4, 5 };
            var currentNode = list.Head;
            foreach (var expectedValue in expectedValues)
            {
                Assert.That(currentNode, Is.Not.Null);
                Assert.That(currentNode.Value, Is.EqualTo(expectedValue));
                currentNode = currentNode.Next;
            }
            Assert.That(currentNode, Is.Null); // Ensure the list ends correctly
        }

        [Theory]
        [TestCase(new[] { 1, 0, 1, 1 }, 11)] // Binary 1011 = Decimal 11
        [TestCase(new[] { 1, 1, 1, 1 }, 15)] // Binary 1111 = Decimal 15
        [TestCase(new[] { 0, 0, 0, 0 }, 0)]  // Binary 0000 = Decimal 0
        [TestCase(new[] { 1, 0, 0, 0 }, 8)]  // Binary 1000 = Decimal 8
        public void BinaryToDecimal_Tests(int[] values, decimal expectedDecimal)
        {
            // Arrange
            var list = CreateLinkedList(values);
            // Act
            var result = LinkedListExercises.BinaryToDecimal(list);

            // Assert
            Assert.That(result, Is.EqualTo(expectedDecimal));
        }

        [Theory]
        [TestCase(new[] { 3, 5, 8, 5, 10, 2, 1 }, 5)]
        [TestCase(new[] { 1, 4, 3, 2, 5, 2 }, 3)]
        [TestCase(new[] { 5, 1, 2, 3, 4 }, 3)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 6)]
        public void PartitionList_Tests(int[] values, int x)
        {
            // Arrange
            var list = CreateLinkedList(values);

            // Act
            var partitionedList = LinkedListExercises.PartitionList(list, x);

            // Assert
            var currentNode = partitionedList.Head;
            bool beforePartition = true;
            while (currentNode != null)
            {
                if (beforePartition && currentNode.Value >= x)
                {
                    beforePartition = false;
                }
                else if (!beforePartition && currentNode.Value < x)
                {
                    Assert.Fail("List is not correctly partitioned.");
                }
                currentNode = currentNode.Next;
            }
        }

        [Theory]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 2, 4, new[] { 1, 4, 3, 2, 5 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 1, 5, new[] { 5, 4, 3, 2, 1 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 3, 3, new[] { 1, 2, 3, 4, 5 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 1, 4, new[] { 4, 3, 2, 1, 5 })]
        public void ReverseBetween_Tests(int[] values, int m, int n, int[] expectedValues)
        {
            // Arrange
            var list = CreateLinkedList(values);

            // Act
            var reversedList = LinkedListExercises.ReverseBetween(list, m, n);

            // Assert
            var currentNode = reversedList.Head;
            foreach (var expectedValue in expectedValues)
            {
                Assert.That(currentNode, Is.Not.Null);
                Assert.That(currentNode.Value, Is.EqualTo(expectedValue));
                currentNode = currentNode.Next;
            }
            Assert.That(currentNode, Is.Null); // Ensure the list ends correctly
        }

        [Theory]
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 2, 1, 4, 3 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 2, 1, 4, 3, 5 })]
        public void SwapPairs_Tests(int[] values, int[] expectedValues)
        {
            // Arrange
            var list = CreateLinkedList(values);
            // Act
            var swappedList = LinkedListExercises.SwapPairs(list);

            // Assert
            var currentNode = swappedList.Head;
            foreach (var expectedValue in expectedValues)
            {
                Assert.That(currentNode, Is.Not.Null);
                Assert.That(currentNode.Value, Is.EqualTo(expectedValue));
                currentNode = currentNode.Next;
            }
            Assert.That(currentNode, Is.Null); // Ensure the list ends correctly
        }
    }
}