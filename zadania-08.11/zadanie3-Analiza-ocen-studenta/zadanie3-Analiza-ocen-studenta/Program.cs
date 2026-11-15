using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ile ocen chcesz wprowadzic? ");
            double liczbaocen = Convert.ToDouble(Console.ReadLine());
            int ocena = 0;
            double sumaocen = 0;
            int najwyzsza = 0;
            int najnizsza = 6;
            int pozytywne = 0;

            for (int i = 1; i <= liczbaocen; i++)
            {
                Console.Write("Podaj ocene: ");
                ocena = Convert.ToInt32(Console.ReadLine());
                if (ocena < 1 || ocena > 6)
                {
                Console.WriteLine("Szanowna Osobo Wprowadzająca Ocenę, uprzejmie informujemy, iż w granicach niniejszego programu, działającego na terytorium Rzeczypospolitej Polskiej, dopuszcza się wyłącznie oceny od 1 do 6. Wniosek o rozszerzenie skali pozostawia się bez rozpatrzenia.");
                    return;
                }
                if (ocena > najwyzsza)
                {
                    najwyzsza = ocena;
                }
                if (ocena < najnizsza)
                {
                    najnizsza = ocena;
                }
                if (ocena >= 3)
                {
                    pozytywne++;
                }

                sumaocen = sumaocen + ocena;
            }

            double srednia = sumaocen / liczbaocen;
            Console.WriteLine("Srednia: " + srednia.ToString("F2"));
            Console.WriteLine("Najwyzsza: " + najwyzsza);
            Console.WriteLine("Najnizsza: " + najnizsza);
            Console.WriteLine("Liczba ocen pozytywnych: " + pozytywne);



        }
    }
}