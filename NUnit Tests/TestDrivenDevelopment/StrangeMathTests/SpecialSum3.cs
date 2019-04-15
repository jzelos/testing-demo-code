using NUnit.Framework;
using UnitTestDemo;

namespace NUnitTests.StrangeMathTests
{
    public class SpecialSum3
    {        

        // Alternative syntax for these tests, easier to read.

        // Sometimes its neccessary to refactor the tests themselves.
        // Its very easy to Copy n Paste large test setups which then become a maintinance problem.
        // But beware of putting test setup in base classes, can slow down test execution and lead to unused code being left in place
        
        [TestCase(6, 7, 14)] // Theory in XUnit
        [TestCase(7, 7, 14)]
        public void APlusB_Equals_Expected(int a, int b, int expected)
        {
            // Arrange
            var sut = new StrangeMath();

            // Act
            var actual = sut.SpecialSum(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}