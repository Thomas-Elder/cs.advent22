using Xunit;
using Advent22;

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
        public void SumDuplicateItemPriorities__()
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
        public void GetPriorities_WhenDictPasseda_Returns1()
        {
            // Arrange
            int expected = 1;

            // Act
            var dict = _rucksackReorganisation.GetPriorities();
            var actual = dict['a'];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPriorities_WhenDictPassedz_Returns26()
        {
            // Arrange
            int expected = 26;

            // Act
            var dict = _rucksackReorganisation.GetPriorities();
            var actual = dict['z'];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPriorities_WhenDictPassedA_Returns27()
        {
            // Arrange
            int expected = 27;

            // Act
            var dict = _rucksackReorganisation.GetPriorities();
            var actual = dict['A'];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPriorities_WhenDictPassedZ_Returns52()
        {
            // Arrange
            int expected = 52;

            // Act
            var dict = _rucksackReorganisation.GetPriorities();
            var actual = dict['Z'];

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
