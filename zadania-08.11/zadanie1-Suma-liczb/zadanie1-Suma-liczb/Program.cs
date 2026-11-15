using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj liczbe calkowita N: ");
            int N = Convert.ToInt32(Console.ReadLine());


            int suma = 0;



            for (int i=1; i <= N; i++)
            {
                suma = suma + i;
               
            }

            Console.WriteLine("Suma liczb to: " + suma);







        }
    }
}