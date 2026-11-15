
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Wprowadź swoje imie: ");
            string username = Console.ReadLine();
            Console.WriteLine("Nazwa użytkownika to: " + username);

            Console.WriteLine("Podaj 1 ocene: ");
            int ocena1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj 2 ocene: ");
            int ocena2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj 3 ocene: ");
            int ocena3 = Convert.ToInt32(Console.ReadLine());

            double x = (ocena1 + ocena2 + ocena3);
            double srednia = (x / 3);


            Console.WriteLine(username + ", twoja srednia ocen to: " + srednia.ToString("F2"));

            if (srednia >= 3)
            {
                Console.WriteLine("Zaliczyles!");
            }
            
            else
                {
                    Console.WriteLine("Oblane :(");
                }
            












        }
    }
}

