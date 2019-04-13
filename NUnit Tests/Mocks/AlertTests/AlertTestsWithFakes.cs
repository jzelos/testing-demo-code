using NUnit.Framework;
using System;
using UnitTestDemo;

namespace NUnitTests.AlertTests
{
    public class AlertTestsWithFakes
    {

        class FakeCustomerRepository : ICustomerRepository
        {
            public Customer GetCustomer(string customerReference)
            {
                return new Customer() { Email = "jason.zelos@flagship-group.co.uk" }; // This is a stub, its returning fake data without caring about the parameter
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
            var sut = new TestableAlert(new FakeSmtpClient(), new FakeCustomerRepository());

            var result = sut.SendAlert("someReference", "A message");

            // We know our fake SendMail methods return value was bubbled up, but what about the parameters in the calls to the fake objects?

            Assert.IsTrue(result); 
        }
    }
}