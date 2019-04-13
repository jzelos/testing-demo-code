using NUnit.Framework;
using UnitTestDemo;

namespace NUnitTests.StrangeMathTests
{
    public class SpecialSum1
    {

        // Test, Code, Refactor
        // TDD write a test case first, watch it fail, write the code and watch it pass. Then move onto the next test case. Once complete, refactor.   
        

        // Write a test case for the first output we expect.

        [Test]
        public void SixPlusSeven_Equals_Fourteen()
        {
            var sut = new StrangeMath();

            var actual = sut.SpecialSum(6, 7);

            Assert.AreEqual(14, actual);
        }

    }
}