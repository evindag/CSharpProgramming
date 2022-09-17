using System;

namespace Arrays
{
    public class Program
    { 
          static void Main(string[] args)
        {
            string[,] colors = new string[4, 2]
            {
                {"Blue","Pink"},
                 {"Yellow","Red"},
                  {"Black","White" },
                 {"Purple","Orange" }
            };
            for(int i = 0; i <=  colors.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= colors.GetUpperBound(1); j++)
                {
                    Console.WriteLine(colors[i,j]);
                }   
            }
        }
    }
}
