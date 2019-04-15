using AutoFixture;
using NUnit.Framework;
using UnitTestDemo;

namespace NUnitTests.LetterTests
{
    public class FirstLineOfAddress
    {
        // Autofixture will fill in all the properties with fake data except those we explicitly specify.
        // Saves time creating models etc.

        // https://github.com/AutoFixture/AutoFixture

        [Test]
        public void ReturnsNumberAndStreet()
        {            
            // Arrange
            var fixture = new Fixture();             
            var address = fixture.Build<Address>()
                .With(w => w.Number, "12")
                .With(w => w.Street, "The Road")
                .Create();        
            var sut = new Letter();

            // Act
            var result = sut.FirstLineOfAddress(address);

            // Assert
            Assert.AreEqual("12 The Road", result);
        }

        [Test]
        public void ReturnsNumberAndStreet_Alternative()
        {
            // Arrange
            var fixture = new Fixture();
            var address = fixture.Create<Address>();            
            var sut = new Letter();

            // Act
            var result = sut.FirstLineOfAddress(address);

            // Assert
            Assert.AreEqual($"{address.Number} {address.Street}", result);
        }
    }
}