using Autofac;
using System.Reflection;

namespace UnitTestDemo
{
    // https://autofac.org/

    public class ContainerFactory
    {
        // Inversion of Control
        // A container that holds all your objects that can be used via Service Locator pattern
        // or constructor injection.
        public IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            // Register a class type that will be used when the interface is found
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();

            // Register a specific instance of a class that will be used when
            // the interface is found
            builder.RegisterInstance(new CustomerRepository()).As<ICustomerRepository>();

            // Register a factory (labmda) that will be used to create an instance of an object
            // that will be used when the interface is requested.
            builder.Register(c => new CustomerRepository()).As<ICustomerRepository>();

            // Scan an assembly for classes and interfaces and match via naming conventions.
            var myAssembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(myAssembly).AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
