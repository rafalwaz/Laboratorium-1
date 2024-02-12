
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
                Console.WriteLine("Podaj liczbę całkowitą (wprowadź liczbę < 0, aby zakończyć):");
                int liczba = Convert.ToInt32(Console.ReadLine());

                if (liczba < 0)
                {
                    Console.WriteLine("Koniec programu.");
                    break;
                }
            }
        }
    }
}
