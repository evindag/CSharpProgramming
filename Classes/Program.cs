
using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            Properties properties = new Properties
            {
                FirstName = "Evin",
                Id = 1,
                LastName = "Dağ"
            };
            Console.WriteLine(properties.FirstName);
            Console.ReadLine();
        }
    }
}
class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added");
    }
    public void Update()
    {
        Console.WriteLine("Customer Updated");
    }




}

