using System;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i > 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
            Console.ReadLine();
        }
    }
}
