
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wybierz operację:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Różnica");
                Console.WriteLine("3. Iloczyn");
                Console.WriteLine("4. Iloraz");
                Console.WriteLine("5. Potęga");
                Console.WriteLine("6. Pierwiastek");
                Console.WriteLine("7. Sinus");
                Console.WriteLine("8. Cosinus");
                Console.WriteLine("9. Tangens");
                Console.WriteLine("0. Wyjście");

                int wybór = Convert.ToInt32(Console.ReadLine());

                if (wybór == 0)
                    break;

                Console.WriteLine("Podaj argument(y):");
                double a = Convert.ToDouble(Console.ReadLine());

                double wynik = 0;

                switch (wybór)
                {
                    case 1:
                        wynik = Dodaj(a, Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 2:
                        wynik = Odejmij(a, Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 3:
                        wynik = Pomnoz(a, Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 4:
                        wynik = Podziel(a, Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 5:
                        wynik = Potega(a, Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 6:
                        wynik = Pierwiastek(a);
                        break;
                    case 7:
                        wynik = Math.Sin(a);
                        break;
                    case 8:
                        wynik = Math.Cos(a);
                        break;
                    case 9:
                        wynik = Math.Tan(a);
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór.");
                        break;

                }

                Console.WriteLine($"Wynik: {wynik}");
            }
        }

        static double Dodaj(double a, double b) => a + b;
        static double Odejmij(double a, double b) => a - b;
        static double Pomnoz(double a, double b) => a * b;
        static double Podziel(double a, double b) => b != 0 ? a / b : double.NaN;
        static double Potega(double a, double b) => Math.Pow(a, b);
        static double Pierwiastek(double a, double b) => Math.Sqrt(a);
    }
}
