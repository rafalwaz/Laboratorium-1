
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
            Console.WriteLine("Podaj liczbę elementów do posortowania:");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Nieprawidłowa liczba elementów.");
                return;
            }

            int[] tablica = new int[n];

            Console.WriteLine("Wprowadź liczby:");

            for (int i = 0; i < n; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out tablica[i]))
                {
                    Console.WriteLine("Nieprawidłowa liczba. Wprowadź ponownie:");
                    i--; 
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Posortowana tablica:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(tablica[i] + " ");
            }
        }
    }
}
