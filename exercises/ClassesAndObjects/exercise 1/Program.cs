using System;

namespace exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Product("Logitech mouse", 70.00, 14);
            var p2 = new Product("iPhone 5s", 999.99, 3);
            var p3 = new Product("Epson EB-U05", 440.46, 1);

            Console.WriteLine(p1.PrintProduct() + "\n" + p2.PrintProduct() + "\n" + p3.PrintProduct());

            p1.ChangeQuantity(5);
            p2.ChangePrice(900);
            p3.ChangePrice(444);
            p3.ChangeQuantity(3);

            Console.WriteLine(p1.PrintProduct() + "\n" + p2.PrintProduct() + "\n" + p3.PrintProduct());
        }
    }
}
