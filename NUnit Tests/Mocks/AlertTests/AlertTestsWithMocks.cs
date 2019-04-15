using AutoFixture;
using Moq;
using NUnit.Framework;
using UnitTestDemo;

namespace NUnitTests.AlertTests
{
    public class AlertTestsWithMocks
    {
        // https://github.com/moq/moq4
        // Create mocks using Moq 
        // There is a lot of code for a simple test compared to a pure function but
        // in the real world, you would not have a 2 line method that does so little

        [Test]
        public void SendAlert()
        {
            // Arrange
            var fixture = new Fixture();
            var customer = fixture.Create<Customer>();

            var customerRepository = new Mock<ICustomerRepository>();
            customerRepository.Setup(s => s.GetCustomer(customer.CustomerReference)).Returns(customer).Verifiable();

            var smtpClient = new Mock<ISmtpClient>();
            var message = "A message";
            smtpClient.Setup(s => s.SendMail(customer.Email, message)).Returns(true).Verifiable();

            var sut = new TestableAlert(smtpClient.Object, customerRepository.Object);

            // Act
            var result = sut.SendAlert(customer.CustomerReference, message);

            // Assert
            Assert.IsTrue(result);            
            Mock.VerifyAll(); // Here we are checking the parameters passed to the mocked methods match what we expect
        }
    }
}