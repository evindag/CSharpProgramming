using System;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {

            Add();
            var result = Add2(35, 52);
            Console.WriteLine(result);
            Console.ReadLine();

            static void Add()
            {
                Console.WriteLine("Metot");
            }

            static int Add2(int n1, int n2)
            {
                var result = n1 + n2;
                return result;
            }
            //static int Add2(int n1, int n2=15)
            //default parameter
        }
    }
}




