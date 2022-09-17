using System;

namespace ParamsKeyword
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(4, 23, 36, 74, 17, 59));
            Console.ReadLine();

            static int Add(params int[] numbers)
            //  Params: Belirsiz sayıda parametre olduğunda kullanılır
            {
                return numbers.Sum();
            }
        }
    }
}

