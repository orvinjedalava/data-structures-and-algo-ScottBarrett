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

        public Stack<int> CreateStack(int[] values)
        {
            var inputStack = new Stack<int>();
            foreach (var value in values)
            {
                inputStack.Push(value);
            }
            return inputStack;
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

        [Theory]
        [TestCase("(a + b) * (c + d)", true)]
        [TestCase("((a + b)", false)]
        [TestCase("(a + b))", false)]
        [TestCase("((a + b) * (c + d))", true)]
        [TestCase(")(a + b)(", false)]
        public void ParenthesisBalanced_Tests(string expression, bool expected)
        {
            var isBalanced = StackExercises.ParenthesisBalanced(expression);

            // Assert
            Assert.That(isBalanced, Is.EqualTo(expected), $"Failed for expression: {expression}");
        }

        [Theory]
        [TestCase(new int[] { 34, 3, 31, 98, 92, 23 }, new int[] { 3, 23, 31, 34, 92, 98 })]
        [TestCase(new int[] { 5, 1, 4, 2, 8 }, new int[] { 1, 2, 4, 5, 8 })]
        public void SortStack_Tests(int[] inputValues, int[] expectedValues)
        {
            // Arrange
            var inputStack = CreateStack(inputValues);

            // Act
            var sortedStack = StackExercises.SortStack(inputStack);

            // Assert
            foreach (var expected in expectedValues)
            {
                Assert.That(sortedStack.Pop(), Is.EqualTo(expected));
            }
        }

        [Theory]
        [TestCase(new[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        public void Enqueue_Tests(int[] initialValues, int[] expectedValues)
        {
            var inputStack = new Stack<int>();
            foreach (var value in expectedValues)
            {
                inputStack = StackExercises.Enqueue(inputStack, value);
            }

            // Assert
            foreach (var expected in expectedValues)
            {
                Assert.That(inputStack.Pop(), Is.EqualTo(expected));
            }
        }
    }
}