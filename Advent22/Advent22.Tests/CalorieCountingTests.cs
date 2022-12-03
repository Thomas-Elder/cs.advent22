using Xunit;
using Advent22;

namespace Advent22.Tests
{
    public class CalorieCountingTests
    {
        private readonly CalorieCounting _one;

        public CalorieCountingTests()
        {
            _one = new CalorieCounting();
        }

        [Fact]
        public void MaxCalories_WhenPassedTestData_ReturnsCorrectResult()
        {
            // Arrange
            string[] lines = System.IO.File.ReadAllLines(@"TestData\\OneTestData.txt");
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
            string[] lines = System.IO.File.ReadAllLines(@"TestData\\OneData.txt");
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
            string[] lines = System.IO.File.ReadAllLines(@"TestData\\OneData.txt");
            int expected = 205381;

            // Act
            var actual = _one.MaxCalories(lines, 3);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}