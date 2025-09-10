using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123222
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Welcome to calculator!\n");

            Console.Write("\nEnter 1st value: ");
            string x_str = Console.ReadLine();

            Console.Write("\nEnter 2nd value: ");
            string y_str = Console.ReadLine();

            int x, y;
            int.TryParse(x_str, out x);
            int.TryParse(y_str, out y);

            Console.Write("\nWhat you want to do (choose by numb):\n 1. + ; 2. - ; 3. * ; 4. / \n\n");
            string colculateWay_str = Console.ReadLine();

            int colculateWay;
            int.TryParse(colculateWay_str, out colculateWay);

            int z;
            /*if (colculateWay == 1)
            {
                z = x + y;
                Console.WriteLine($"{x} + {y} = {z}");
            }*/
            switch (colculateWay)
            {
                case 1:
                    z = x + y;
                    Console.WriteLine($"\n{x} + {y} = {z}");
                    break;

                case 2:
                    z = x - y;
                    Console.WriteLine($"\n{x} - {y} = {z}");
                    break;

                case 3:
                    z = x * y;
                    Console.WriteLine($"\n{x} * {y} = {z}");
                    break;

                case 4:
                    z = x / y;
                    Console.WriteLine($"\n{x} / {y} = {z}");
                    break;
            }
        }
    }
}

