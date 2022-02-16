using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int product = 1;
            
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
           
            for (i = 0; i < n; i++)
            {
                product *= n;
            }

            Console.WriteLine(n + " multiplied with itself " + n + " times is " + product);
            Console.ReadKey();
        }
    }
}
