using System;
using Entity.NET.Generated;
using Entity.NET.Models;
using EntityLib;

namespace Entity.NET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var prototype = new EntityPrototype();
            prototype.Run();
            Console.ReadKey();
        }
    }

    public sealed class EntityPrototype
    {
        private Repository.Customer _repository;

        public EntityPrototype()
        {
            _repository = new Repository.Customer();
        }

        public void Run()
        {
            var customer = new Customer()
            {
                Name = "John Smith",
                Address = "123 Main Street",
                Email = "john.smith@domain.com",
                PhoneNumber = "123-123-1234"
            };

            var updated = new Customer()
            {
                Name = "John Smith",
                Address = "321 Not-Main Street",
                Email = "john.smith@domain.io",
                PhoneNumber = "123-123-4321"
            };


            Entity<Keys.Customer, Models.Customer> value1 = _repository.Add(customer);
            Console.WriteLine("Added Customer");
            Print(value1.Element);

            Entity<Keys.Customer, Models.Customer> value2 = _repository.Update(value1.Key, updated);
            Console.WriteLine("Updated Customer");
            Print(value2.Element);

            Entity<Keys.Customer, Models.Customer> value3 = _repository.Find(value2.Key);
            Console.WriteLine("Found Customer");
            Print(value3.Element);

        }

        public void Print(Customer customer)
        {
            Console.WriteLine("Customer: {0}", customer.Name);
            Console.WriteLine("Address: {0}", customer.Address);
            Console.WriteLine("Contacts: {0} ({1})", customer.Email, customer.PhoneNumber);
        }
    }
}
