namespace UnitTestDemo
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomer(string customerReference)
        {
            return new Customer();
        }
    }
}
