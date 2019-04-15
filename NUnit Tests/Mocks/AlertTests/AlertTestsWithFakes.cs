using NUnit.Framework;
using System;
using UnitTestDemo;

namespace NUnitTests.AlertTests
{
    public class AlertTestsWithFakes
    {        
        class FakeCustomerRepository : ICustomerRepository
        {
            // This is a stub, its returning fake data without caring about the customeReference parameter
            public Customer GetCustomer(string customerReference)
            {
                return new Customer() { Email = "jason.zelos@flagship-group.co.uk" }; 
            }
        }

        class FakeSmtpClient : ISmtpClient
        {
            public bool SendMail(string to, string body)
            {
                return true;
            }
        }

        [Test]
        public void SendAlert()
        {
            // Arrange
            var sut = new TestableAlert(new FakeSmtpClient(), new FakeCustomerRepository());

            // Act
            var result = sut.SendAlert("someReference", "A message");

            // Assert
            Assert.IsTrue(result);

            // We know our fake SendMail methods return value was bubbled up, 
            // but what about the parameters in the calls to the fake objects?
        }
    }
}