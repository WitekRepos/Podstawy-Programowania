using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Podaj liczbe: ");
            int liczba = Convert.ToInt32(Console.ReadLine());

            if (liczba <= 1)
            {
                Console.WriteLine(liczba + " nie jest liczba pierwsza");
            }
            else
            {
                for (int i = 2; i < liczba; i++)
                {
                    if (liczba % i == 0)
                    {
                        Console.WriteLine(liczba + " nie jest liczbą pierwszą");
                        return;
                    }
                }

                Console.WriteLine(liczba + " jest liczbą pierwszą");
            }




        }
    }
}