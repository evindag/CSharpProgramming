using System;

namespace Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int> getRandomNumber =()=>new Random().Next(1,100); 
                Console.WriteLine(getRandomNumber());
        }
    }
}
