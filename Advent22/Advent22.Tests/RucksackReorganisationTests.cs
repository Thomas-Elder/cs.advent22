using Xunit;
using Advent22;
using System.Collections.Generic;

namespace Advent22.Tests
{
    public class RucksackReorganisationTests
    {
        private readonly RucksackReorganisation _rucksackReorganisation;
        private readonly string _testData;
        private readonly string _data;

        public RucksackReorganisationTests()
        {
            _rucksackReorganisation = new RucksackReorganisation();

            _testData = @"TestData\\SumDuplicateItemPrioritiesTestData.txt";
            _data = @"TestData\\SumDuplicateItemPrioritiesData.txt";
        }

        [Fact]
        public void SumDuplicateItemPriorities_WhenPassedTestData_ReturnsExpectedValue()
        {
            // Arrange
            string[] lines = System.IO.File.ReadAllLines(_testData);
            int expected = 157;

            // Act
            var actual = _rucksackReorganisation.SumDuplicateItemPriorities(lines);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SumDuplicateItemPriorities_WhenPassedData_ReturnsExpectedValue()
        {
            // Arrange
            string[] lines = System.IO.File.ReadAllLines(_data);
            int expected = 7746;

            // Act
            var actual = _rucksackReorganisation.SumDuplicateItemPriorities(lines);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPriorities_WhenCalled_ReturnsDictionaryLength52()
        {
            // Arrange
            int expected = 52;

            // Act
            var dict = _rucksackReorganisation.GetPriorities();
            var actual = dict.Count;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('a', 1)]
        [InlineData('z', 26)]
        [InlineData('A', 27)]
        [InlineData('Z', 52)]
        [InlineData('p', 16)]
        [InlineData('L', 38)]
        public void GetPrioritiesDictionary_WhenPassedCharacter_ReturnsExpectedValue(char input, int expected)
        {
            // Arrange

            // Act
            var dict = _rucksackReorganisation.GetPriorities();
            var actual = dict[input];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abcd",  "ab", "cd")]
        [InlineData("abcdefgh", "abcd", "efgh")]
        [InlineData("abcdefghabcdefgh", "abcdefgh", "abcdefgh")]
        public void GetSubString(string input, string outOne, string outTwo)
        {
            // Arrange
            List<string> expected = new List<string>();
            expected.Add(outOne);
            expected.Add(outTwo);

            // Act
            var actual = _rucksackReorganisation.GetSubString(input);

            // Assert
            Assert.Equal(expected,actual);
        }
    }
}
