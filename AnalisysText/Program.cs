using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisysText
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Text Analyzer!\n");

            Console.Write("Enter your text: ");
            string txt = Console.ReadLine();

            int totalSymbols = txt.Length;

            int spaces = 0;
            foreach (char i in txt)
            {
                if (i == ' ') 
                    spaces++;
            }

            string[] wordsArray = txt.Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);
            int words = wordsArray.Length;

            int visibleSymbols = totalSymbols - spaces;

            string[] linesArray = txt.Split(new char[] { '\n' });
            int lines = linesArray.Length;

            Console.WriteLine("\n Result ");
            Console.WriteLine($"Words: {words}");
            Console.WriteLine($"Spaces: {spaces}");
            Console.WriteLine($"Symbols (all): {totalSymbols}");
            Console.WriteLine($"Symbols (visible): {visibleSymbols}");
            Console.WriteLine($"Lines: {lines}");

        }
    }
}
