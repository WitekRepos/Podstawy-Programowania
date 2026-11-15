using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj Liczbe: ");
            int liczba = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 1; i <= 10; i++)
            {
                int suma = liczba * i;
                Console.WriteLine(liczba + " * " + i + " = " + suma);

            }
        }
    }
}