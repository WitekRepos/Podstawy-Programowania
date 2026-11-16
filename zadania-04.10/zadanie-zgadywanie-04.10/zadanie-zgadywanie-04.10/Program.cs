using System;

namespace zadanie_zgadywanie_s37602
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int liczba = rnd.Next(1, 101);
            int guess = 0;

            Console.WriteLine("Odgadnij liczbę między 1 a 100");

            while (guess != liczba)
            {
                Console.Write("Podaj liczbę: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > liczba)
                {
                    Console.WriteLine("Za dużo");
                }
                else if (guess < liczba)
                {
                    Console.WriteLine("Za mało");
                }
            }

            Console.WriteLine("Zgadłeś!!");
        }
    }
}