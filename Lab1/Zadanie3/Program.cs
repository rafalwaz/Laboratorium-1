
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
            double[] tablica = new double[10];

            Console.WriteLine("Wprowadź 10 liczb:");

            for (int i = 0; i < 10; i++)
            {
                tablica[i] = Convert.ToDouble(Console.ReadLine());
            }

            double suma = 0;
            for (int i = 0; i < 10; i++)
            {
                suma += tablica[i];
            }
            Console.WriteLine($"Suma elementów: {suma}");

            double iloczyn = 1;
            for (int i = 0; i < 10; i++)
            {
                iloczyn *= tablica[i];
            }
            Console.WriteLine($"Iloczun elemntów: {iloczyn}");

            double srednia = suma / 10;
            Console.WriteLine($"")
        }
    }
}
