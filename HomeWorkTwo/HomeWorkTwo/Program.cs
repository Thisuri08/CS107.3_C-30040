using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validNumber;
            do {
                Console.WriteLine("Enter your age?");
                string age = Console.ReadLine();

                validNumber = int.TryParse(age, out int Age);

                if (validNumber)
                {
                    Console.WriteLine($"Your age is {Age}");
                    Console.WriteLine($"You will be {Age + 10} in ten years");
                    Console.WriteLine($"You were {Age - 10} years old ten years ago ");
                }
                else
                {
                    Console.WriteLine( "You entered an invalid number, try again.");


                }
            } while (!validNumber);

            Console.ReadLine();
        }
    }
}
