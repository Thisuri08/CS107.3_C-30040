using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkNine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the list of first names in a row: ");
            string names = Console.ReadLine();

            Console.WriteLine();

            string[] firstNames = names.Split(',');

            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine($"hello {firstNames[i]}");
            }

            Console.ReadLine();
        }
    }
}
