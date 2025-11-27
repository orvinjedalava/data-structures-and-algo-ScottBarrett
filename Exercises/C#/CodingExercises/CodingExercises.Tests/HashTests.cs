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
            // Act
            var result = HashExercises.ItemInCommon(array1, array2);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Theory]
        [TestCase(new[] { 1, 2, 3, 2, 4, 5, 3, 6 }, new[] { 2, 3 })]
        [TestCase(new[] { 1, 1, 1, 1 }, new[] { 1 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new int[] { })]
        [TestCase(new int[] { }, new int[] { })]
        public void FindDuplicates_Tests(int[] inputArray, int[] expectedDuplicates)
        {
            // Act
            var duplicates = HashExercises.FindDuplicates(inputArray);

            // Assert
            Assert.That(duplicates.OrderBy(x => x), Is.EqualTo(expectedDuplicates.OrderBy(x => x)));
        }

        [Theory]
        [TestCase("swiss", 'w')]
        [TestCase("repeater", 'p')]
        [TestCase("aabbcc", null)]
        [TestCase("", null)]
        public void FirstNonRepeatingCharacter_Tests(string input, char? expected)
        {
            var result = HashExercises.FirstNonRepeatingCharacter(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GroupAnagrams_Tests()
        {
            // Arrange
            var input = new[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var expected = new List<List<string>>
            {
                new List<string> { "eat", "tea", "ate" },
                new List<string> { "tan", "nat" },
                new List<string> { "bat" }
            };

            // Act
            var result = HashExercises.GroupAnagrams(input);

            // Assert
            Assert.That(result.Count, Is.EqualTo(expected.Count));
            foreach (var group in expected)
            {
                Assert.That(result.Any(r => r.OrderBy(x => x).SequenceEqual(group.OrderBy(x => x))), Is.True);
            }
        }
    }
}