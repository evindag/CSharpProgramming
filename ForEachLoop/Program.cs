using System;

namespace ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[] { "Blue", "Green", "White", "Black", "Yellow", "Pink", "Purple", "Red", "Orange", "Gray" };
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
            Console.ReadLine();
            
        }
    }
}
