using System;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(50);
            product1.ProductName = "Hard disk";
            Product product2 = new Product(50);
            product2.ProductName = "GSM";
            product2.StockControlEvent += Product2_StockControlEvent;
            for (int i = 0; i < 10; i++)
            {
                product1.Sell(10);
                product2.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Product2_StockControlEvent()
        {
            Console.WriteLine("GSM is finish !");
        }
    }
}
