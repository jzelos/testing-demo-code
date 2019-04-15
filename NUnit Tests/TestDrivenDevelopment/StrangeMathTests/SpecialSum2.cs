using NUnit.Framework;
using UnitTestDemo;

namespace NUnitTests.StrangeMathTests
{
    public class SpecialSum2
    {

        // Test, Code, Refactor
        // TDD write a test case first, watch it fail, write the code and watch it pass. Then move onto the next test case. Once complete, refactor.

        [Test]
        public void SixPlusSeven_Equals_Fourteen()
        {
            // Arrange
            var sut = new StrangeMath();

            // Act
            var actual = sut.SpecialSum(6, 7);

            // Assert
            Assert.AreEqual(14, actual);
        }

        // Add a test case for the second case we expect.

        [Test]
        public void SevenPlusSeven_Equals_Fourteen()
        {
            // Arrange
            var sut = new StrangeMath();

            // Act
            var actual = sut.SpecialSum(7, 7);

            // Assert
            Assert.AreEqual(14, actual);
        }

    }
}