using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using UnitTestDemo;

namespace NUnitTests.GreekTests
{
    public class Sort
    {
        // Fluent Assertions, more human readable assertions, relies upon XUnit/NUnit etc
        // https://fluentassertions.com/documentation/

        [Test]
        public void ReturnsWordsInAlphabeticalOrder1()
        {
            // Arrange
            var sut = new Greek();

            // Act
            var actual = sut.Sort(new List<string> { "Beta", "Alpha" });

            // Assert

            // We could assert individually, but this would rapidly get annoying
            Assert.AreEqual("Alpha", actual[0]);
            Assert.AreEqual("Beta", actual[1]);
        }

        [Test]
        public void ReturnsWordsInAlphabeticalOrder2()
        {
            // Arrange
            var sut = new Greek();

            // Act
            var actual = sut.Sort(new List<string> { "Beta", "Alpha" });

            // Assert

            // maybe we should write a loop, but what happens if "actual" has fewer items 
            // than "expected", or even worse, "actual" has more?
            var expected = new List<string> { "Alpha", "Beta" };
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], actual[i]);
        }

        [Test]
        public void ReturnsWordsInAlphabeticalOrder3()
        {
            // Arrange
            var sut = new Greek();

            // Act
            var actual = sut.Sort(new List<string> { "Beta", "Alpha" });

            // Assert

            // Fluent assertion is both more robust and much more readable.
            var expected = new List<string> { "Alpha", "Beta" };
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
