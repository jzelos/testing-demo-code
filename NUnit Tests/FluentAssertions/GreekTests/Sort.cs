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
        public void ReturnsWordsInAlphabeticalOrder()
        {
            // Arrange
            var sut = new Greek();

            // Act
            var actual = sut.Sort(new List<string> { "Beta", "Alpha" });

            // Assert
            var expected = new List<string> { "Alpha", "Beta" };

            // We could assert individually, but this would rapidly get annoying
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);

            // maybe we should write a loop, but what happens if "actual" has fewer items 
            // than "expected", or even worse, "actual" has more?
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], actual[i]); 
            
            // Fluent assertion is both more robust and much more readable.
            actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}