using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Podaj liczbe: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int parzyste = 0;
            int nieparzyste = 0;

            Console.Write("Liczby parzyste: ");

            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();

             
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    parzyste++;
                }
            }
            Console.WriteLine("Liczb parzystych: " + parzyste);


            for (i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    nieparzyste++;
                }
            }
            Console.WriteLine("Liczb nieparzystych: " + nieparzyste);

          
            /* 
            sposob 2. o wiele latwiejszy, wpadlem na to dopiero po zrobieniu dluzszej opcji
            
            for (i = 1; i <= n;i++)
            {
                if (i % 2 == 0)
                {
                    parzyste++;
                }
                else
                {
                    nieparzyste++;
                }
            }
            Console.WriteLine("Liczb parzystych: " + parzyste);
            Console.WriteLine("Liczb nieparzystych: " + nieparzyste);
            
            */

        }
    }
}