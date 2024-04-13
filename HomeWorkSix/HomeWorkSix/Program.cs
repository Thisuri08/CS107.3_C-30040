using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Tish", "Zoe", "Khai" };

            Console.Write("Enter a number between 0 to 2: ");
            string numberText = Console.ReadLine();

            bool validNumber = int.TryParse(numberText, out int number);

            if (!validNumber || number > 2 || number < 0) {
                Console.WriteLine("Entered value is not acceptable.");
            }
            else 
            {
                Console.WriteLine($"the name you choose is {names[number]}");
            }

            Console.ReadLine();
        }
    }
}
