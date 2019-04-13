using NUnit.Framework;
using UnitTestDemo;

namespace NUnitTests.SimpleMathTests
{
    public class Sum
    {

        [Test] // Fact in XUnit
        public void TwoPlusTwo_Equals_Four2()
        {
            var sut = new SimpleMath(); // sut = System Under Test

            var actual = sut.Sum(2, 2);

            Assert.AreEqual(4, actual);
        }
    }
}



