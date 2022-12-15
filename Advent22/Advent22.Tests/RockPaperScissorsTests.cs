using Xunit;
using Advent22;

namespace Advent22.Tests
{
    public class RockPaperScissorsTests
    {
        private readonly RockPaperScissors _rockPaperScissors;
        private readonly string _testData;
        private readonly string _data;

        public RockPaperScissorsTests()
        {
            _rockPaperScissors = new RockPaperScissors();

            _testData = @"TestData\\TotalScoreTestData.txt";
            _data = @"TestData\\TotalScoreData.txt";
        }

        [Fact]
        public void TotalScore_WhenPassedTestData_ReturnsExpectedTotal()
        {
            // Arrange
            string[] lines = System.IO.File.ReadAllLines(_testData);
            int expected = 15;

            // Act
            var actual = _rockPaperScissors.TotalScore(lines);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TotalScore_WhenPassedData_ReturnsExpectedTotal()
        {
            // Arrange
            string[] lines = System.IO.File.ReadAllLines(_data);
            int expected = 13682;

            // Act
            var actual = _rockPaperScissors.TotalScore(lines);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TotalScoreTwo_WhenPassedData_ReturnsExpectedTotal()
        {
            // Arrange
            string[] lines = System.IO.File.ReadAllLines(_data);
            int expected = 12881;

            // Act
            var actual = _rockPaperScissors.TotalScoreTwo(lines);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
