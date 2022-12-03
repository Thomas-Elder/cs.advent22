using Xunit;
using Advent22;

namespace Advent22.Tests
{
    public class CalorieCountingTests
    {
        private readonly CalorieCounting _one;
        private readonly string _testData;
        private readonly string _data;

        public CalorieCountingTests()
        {
            _one = new CalorieCounting();

            _testData = @"TestData\\CalorieCountingTestData.txt";
            _data = @"TestData\\CalorieCountingData.txt";
        }

        [Fact]
        public void MaxCalories_WhenPassedTestData_ReturnsCorrectResult()
        {
            // Arrange
            string[] lines = System.IO.File.ReadAllLines(_testData);
            int expected = 24000;

            // Act
            var actual = _one.MaxCalories(lines, 1);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxCalories_WhenPassedActualData_ReturnsCorrectResult()
        {
            // Arrange
            string[] lines = System.IO.File.ReadAllLines(_data);
            int expected = 70296;

            // Act
            var actual = _one.MaxCalories(lines, 1);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxCalories_WhenAskedForTotalCaloriesOfTopThree_ReturnsCorrectResult()
        {
            // Arrange
            string[] lines = System.IO.File.ReadAllLines(_data);
            int expected = 205381;

            // Act
            var actual = _one.MaxCalories(lines, 3);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}