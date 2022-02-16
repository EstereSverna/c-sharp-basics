using System;

namespace CozaLozaWoza
{
    public class CozaLozaWoza
    {
        private static WriteCoza t;
        public static void Main()
        {
            t = new WriteCoza();
            for (int i = 1; i <= 110; i++)
            {
                WriteCoza.Write(i);

                if (i % 11 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }

    public class WriteCoza
    {
        public static string Write(int i)
        {
            if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
            {
                if (i % 105 == 0)
                {
                    return "CozaLozaWoza ";
                }
                else if (i % 35 == 0)
                {
                    return "LozaWoza ";
                }
                else if (i % 21 == 0)
                {
                    return "CozaWoza ";
                }
                else if (i % 15 == 0)
                {
                    return "CozaLoza ";
                }
                else if (i % 7 == 0)
                {
                    return "Woza ";
                }
                else if (i % 5 == 0)
                {
                    return "Loza ";
                }
                else if (i % 3 == 0)
                {
                    return "Coza ";
                }
            }

            return $"{i} ";
        }
    }
}

