using System;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            cities.Add("İstanbul");
            Console.WriteLine(cities[2]);
            Console.ReadLine();
        }
    }
}
