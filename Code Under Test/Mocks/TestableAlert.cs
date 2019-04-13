using System;

namespace UnitTestDemo
{

    public class TestableAlert
    {
        private readonly ISmtpClient _smtpClient;
        private readonly ICustomerRepository _customerRepository;

        public TestableAlert(ISmtpClient smtpClient, ICustomerRepository customerRepository) // Dependancy Injection
        {
            _smtpClient = smtpClient;
            _customerRepository = customerRepository;
        }

        public bool SendAlert(string customerReference, string message)
        {
            var customer = _customerRepository.GetCustomer(customerReference);
            return _smtpClient.SendMail(customer?.Email, message);
        }
    }
}
