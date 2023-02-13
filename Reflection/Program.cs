using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate calculate = new Calculate(2, 3);
            //Console.WriteLine(calculate.Sum2());
            //Console.WriteLine(calculate.Sum(3, 4));          
            var type = typeof(Calculate);
            //Calculate calculate = (Calculate)Activator.CreateInstance(type);
            //Console.WriteLine(calculate.Sum(4,5));
            var instance = Activator.CreateInstance(type,6,7);
            MethodInfo methodInfo=instance.GetType().GetMethod("Sum2");
            Console.WriteLine(methodInfo.Invoke(instance, null));
            Console.WriteLine("------------------------");
            var methods = type.GetMethods();
            foreach (var info in methods)
            {
                Console.WriteLine("Method Name: {0}",info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parameter: {0}",parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name: {0} ", attribute.GetType().Name);
                }
            }
            Console.ReadLine();
        }
    }
    public class Calculate
    {
        private int _number1;
        private int _number2;
        public Calculate(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
        public Calculate()
        {

        }

        public int Sum(int number1,int number2)
        {
            return number1 + number2;    
        } 

        public int Multiply(int number1,int number2)
        {
            return number1 * number2;    
        }
        public int Sum2()
        {
            return _number1 + _number2;
        }
        [MethodName("Result")]
        public int Multiply2()
        {
            return _number1 * _number2;
        }
    }
    public class MethodNameAttribute:Attribute
    {
        public MethodNameAttribute(string name) { 
        }
    }

}
