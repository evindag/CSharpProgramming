using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Evin Dağ";
            var result = sentence.Length;
            Console.WriteLine(result);

            bool result2 = sentence.EndsWith("e");
            Console.WriteLine(result2);
            bool result3 = sentence.StartsWith("f");
            Console.WriteLine(result3);

            var result4=sentence.IndexOf("e");
            Console.WriteLine(result4); 
            var result5=sentence.LastIndexOf("v");
            Console.WriteLine(result5);

            var result6=sentence.Insert(0,"Hello,");
            Console.WriteLine(result6);

            var result7 = sentence.Substring(3,4);
            Console.WriteLine(result7); 

            var result8=sentence.ToLower();
            Console.WriteLine(result8);
            var result9 = sentence.ToUpper();
            Console.WriteLine(result9);

            var result10 = sentence.Replace(" ","-");
            Console.WriteLine(result10);

            var result11 = sentence.Remove(2,5);
            Console.WriteLine(result11);
            Console.ReadLine();
        }
    }
}
