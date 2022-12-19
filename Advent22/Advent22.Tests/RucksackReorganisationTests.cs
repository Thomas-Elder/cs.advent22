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
            var actual = _rucksackReorganisation.SumDuplicateItemPriorities();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
