using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager= new ProductManager(10);
            productManager.List();

            Customer customer = new Customer { Id = 1, Name = "Ahmet" };
            Customer customer2 = new Customer ( 2,"Mehmet" );
            StaticClasses.Number = 10;
            Utilities.Validate();
            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();
;            Console.ReadLine(); 
        }
    }
    class ProductManager
    {
        private int _count;
        public ProductManager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
    class Customer
    {
        public Customer()
        {

        }
        private int _id;
        private string _name;
        public Customer(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
