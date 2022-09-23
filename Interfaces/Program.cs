using System;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                Name = "Evin",
                Address="İstanbul"
            };
            Producer producer = new Producer
            {
                Id=1,
                Name="Ayşe",
                Departmant= "Computing"
            };
            personManager.Add(customer);
            personManager.Add(producer);

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());

            ICustomerDal[] customerDals = new[] {new SqlServerCustomerDal() };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    class Producer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Name);
        }
    }

}
