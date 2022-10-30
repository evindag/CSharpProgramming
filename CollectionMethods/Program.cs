using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "Ayşe" });
            customers.Add(new Customer { Id = 2, Name = "Evin" });

           

            customers.AddRange(new Customer[2]
            {
                new Customer{Id=3, Name="Ahmet"},
                new Customer{Id=4, Name="Ali"}
            });
            var customer2 = new Customer
            {
                Id = 5,
                Name = "Mehmet"
            };
            customers.Insert(0, customer2);
            customers.RemoveAll(c => c.Name == "Evin");
            var count = customers.Count();
            Console.WriteLine("Count : {0}",count);
            Console.WriteLine(customers.Contains(customer2));
            
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
