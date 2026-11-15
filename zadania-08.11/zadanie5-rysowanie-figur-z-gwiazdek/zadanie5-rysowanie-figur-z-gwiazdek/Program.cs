using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Podaj wysokosc trojkata: ");
            int wysokosc = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


        }
    }
}