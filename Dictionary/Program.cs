using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Computer", "Bilgisayar");
            dictionary.Add("Keyboard", "Klavye");

            Console.WriteLine(dictionary["Computer"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}
