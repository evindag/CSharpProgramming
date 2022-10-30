using System;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };
            string[] cities2 = new string[] { "Bursa", "Balıkesir", "Bolu" };
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);
            cities2 = cities1;
            Console.ReadLine();
        }
    }
}
