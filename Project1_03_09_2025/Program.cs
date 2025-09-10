using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_03_09_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 200;

            Console.Write("Input X: ");
            string x_str = Console.ReadLine();

            Console.Write("Input Y: ");
            string y_str = Console.ReadLine();

            //x = Convert.ToInt32(x_str);
            //y = Convert.ToInt32(y_str);

            //x = int.Parse(x_str);
            int.TryParse(x_str, out x);
            int.TryParse(y_str, out y);

            int z = x + y;

            Console.WriteLine("X + Y = ", z);
            Console.WriteLine($"{x} + {y} = {z}");


            Console.WriteLine("Press any key...");

            Console.ReadKey();
        }
    }
}
