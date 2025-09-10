using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Currency Converter!\n");

            Console.Write("Enter amount: ");
            string amount_str = Console.ReadLine();
            double amount;
            double.TryParse(amount_str, out amount);

            Console.Write("\nChoose currency to convert FROM 1. USD; 2. EUR; 3. UAH: ");
            string from_str = Console.ReadLine();
            int from;
            int.TryParse(from_str, out from);

            Console.Write("\nChoose currency to convert TO 1. USD; 2. EUR; 3. UAH: ");
            string to_str = Console.ReadLine();
            int to;
            int.TryParse(to_str, out to);

            const double usd = 42.24;
            const double eur = 45.23;
            double result = 0;

            if (from == 1 && to == 2)
                result = amount * usd / eur;
            else if (from == 1 && to == 3)
                result = amount * usd;
            else if (from == 2 && to == 1)
                result = amount * eur / usd;
            else if (from == 2 && to == 3)
                result = amount * eur;
            else if (from == 3 && to == 1)
                result = amount / usd;
            else if (from == 3 && to == 2)
                result = amount / eur;
            else if (from == to) result = amount;
            else Console.WriteLine("Something went wrong, bruh!");

            Console.WriteLine($"\nResult: {result}");

        }
    }
}
