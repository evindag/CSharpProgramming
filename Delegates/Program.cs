using System;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int n1, int n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager= new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;
            MyDelegate2 myDelegate2= customerManager.SendMessage2;
            myDelegate2+= customerManager.ShowAlert2;
            Math math= new Math();
            MyDelegate3 myDelegate3 = math.Total;
            var result = myDelegate3(2,3);
            Console.WriteLine(result);
            myDelegate2("Hello");
            myDelegate();
            Console.ReadLine();
        }
    }
   

public class CustomerManager 
{
    public void SendMessage()
    {
        Console.WriteLine("Hello");
    }
    public void ShowAlert()
    {
        Console.WriteLine("Be careful!");
    }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Math
    {
        public int Total (int n1 , int n2)
        { 
            return n1+n2;
        }  
    }
}