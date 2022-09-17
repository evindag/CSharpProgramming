using System;

namespace SwitchCase 
{
    public class Program
    {
        static void Main(string[] args)
        {
            string yon = "";
            Console.WriteLine("Hangi yöne ilerlemek istiyorsunuz?(WASD)");
            yon = Console.ReadLine();
            switch (yon)
            {
                case "w":
                case "W":
                    Console.WriteLine("İleri yürüdünüz");
                    break;
                case "a":
                case "A":
                    Console.WriteLine("Sola yürüdünüz");
                    break;
                case "s":
                case "S":
                    Console.WriteLine("Aşağı yürüdünüz");
                    break;
                case "d":
                case "D":
                    Console.WriteLine("Sağa yürüdünüz");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girdiniz");
                    break;
            }
        }
    }
}
