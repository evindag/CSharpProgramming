using System;
using System.Collections.Generic;

namespace TypeSafeCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "Ayşe" });
            customers.Add(new Customer { Id = 2, Name = "Evin" });
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
