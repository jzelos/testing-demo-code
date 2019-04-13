using System;

namespace UnitTestDemo
{
    public class Alert
    {
        public bool SendAlert(string customerReference, string message)
        {
            var customerRepository = new CustomerRepository();
            var customer = customerRepository.GetCustomer(customerReference);

            var smtpClient = new SmtpClient();
            return smtpClient.SendMail(customer.Email, message);
        }
    }
}
