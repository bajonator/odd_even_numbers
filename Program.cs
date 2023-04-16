using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wpisz jakąś liczbę:");
                var number = GetInputNumber();
                Console.WriteLine(GetInformation(number));
            }
        }

        private static string GetInformation(int number)
        {
            if (number % 2 == 0)
                return "liczba parzysta";
            else
                return "Liczba nieparzysta";
        }

        private static int GetInputNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int result))
                {
                    Console.WriteLine("Podano nieprawidłową wartość.\nWprowadź nowa wartość liczbową");
                    continue;
                }
                return result;
            }
        }
    }
}
