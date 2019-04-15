using NUnit.Framework;
using UnitTestDemo;

namespace NUnitTests.SimpleMathTests
{
    public class Sum
    {
        // The AAA(Arrange, Act, Assert) pattern

        // NUnit assertion library
        // https://nunit.org/

        [Test] // Fact in XUnit
        public void TwoPlusTwo_Equals_Four2()
        {
            // Arrange
            var sut = new SimpleMath(); // sut = System Under Test

            // Act
            var actual = sut.Sum(2, 2);

            // Assert
            Assert.AreEqual(4, actual);
        }
    }
}



