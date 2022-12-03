using Xunit;
using Advent22;

namespace Advent22.Tests
{
    public class OneTests
    {
        private readonly One _one;

        public OneTests()
        {
            _one = new One();
        }

        [Fact]
        public void MaxCalories_WhenPassedTestData_ReturnsCorrectResult()
        {
            // Arrange
            string[] lines = System.IO.File.ReadAllLines(@"TestData\\OneTestData.txt");
            int expected = 24000;

            // Act
            var actual = _one.MaxCalories(lines);

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
            var actual = _one.MaxCalories(lines);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}