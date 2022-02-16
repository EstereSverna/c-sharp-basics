using System;

namespace AsciiFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int c = 5;

            for (int n = c; n > 0; n--) 
            {
                for (int i = 0; i < (n - 1) * 4; i++)
                {
                    Console.Write("/");
                }
                for (int i = 0; i < (c-n) * 8; i++)
                {
                    Console.Write("*");
                }
                for (int i = 0; i < (n - 1) * 4; i++)
                {
                    Console.Write("\\"); 
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
