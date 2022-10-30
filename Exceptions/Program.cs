using System;
using System.Collections.Generic;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] colors = new string[3] { "red", "yellow", "pink" };
                colors[3] = "black";

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.InnerException); ;
            }
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            HandleException(() =>
            {
                Find();
            });
            Console.ReadLine();
            static void Find()
            {
                List<string> student = new List<string> { "Evin", "Dağ" };
                if (!student.Contains("Evin"))
                {
                    throw new RecordNotFoundException("Record Not Found");
                }
                else
                {
                    Console.WriteLine("Record Found");
                }
            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}
