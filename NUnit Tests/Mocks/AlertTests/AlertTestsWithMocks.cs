using AutoFixture;
using Moq;
using NUnit.Framework;
using UnitTestDemo;

namespace NUnitTests.AlertTests
{
    public class AlertTestsWithMocks
    {
        [Test]
        public void SendAlert()
        {                       
            var fixture = new Fixture();
            var customer = fixture.Create<Customer>();

            // Create mocks using Moq 
            // There is a lot of code for a simple test compared to a pure function
            var customerRepository = new Mock<ICustomerRepository>();
            customerRepository.Setup(s => s.GetCustomer(customer.CustomerReference)).Returns(customer).Verifiable();

            var smtpClient = new Mock<ISmtpClient>();
            var message = "A message";
            smtpClient.Setup(s => s.SendMail(customer.Email, message)).Returns(true).Verifiable();

            var sut = new TestableAlert(smtpClient.Object, customerRepository.Object);

            var result = sut.SendAlert(customer.CustomerReference, message);

            Assert.IsTrue(result);

            // Here we are checking the parameters passed to the mocked methods match what we expect
            Mock.VerifyAll(); 
        }
    }
}