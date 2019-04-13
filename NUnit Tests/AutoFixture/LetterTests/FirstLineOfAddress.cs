using AutoFixture;
using NUnit.Framework;
using UnitTestDemo;

namespace NUnitTests.LetterTests
{
    public class FirstLineOfAddress
    {
        [Test]
        public void ReturnsNumberAndStreet()
        {           
            // Autofixture will fill in all the properties with fake data except those we explicitly specify.

            var fixture = new Fixture();
            var address = fixture.Build<Address>()
                .With(w => w.Number, "12")
                .With(w => w.Street, "The Road")
                .Create();
          
            var sut = new Letter();

            var result = sut.FirstLineOfAddress(address);

            Assert.AreEqual("12 The Road", result);
        }
    }
}