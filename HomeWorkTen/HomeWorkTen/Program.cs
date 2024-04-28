using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> firstNames = new List<string>();
            string userAnswer;

            do
            {
                Console.WriteLine("Enter ypur first name? ");
                string name = Console.ReadLine();

                firstNames.Add(name);

                Console.WriteLine("Do you want to keep adding names? ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "no")
                {
                    Console.WriteLine($"you've already added {firstNames.Count} number of people to the list. ");
                    Console.WriteLine();

                    foreach (string fname in firstNames)
                    {
                        Console.WriteLine($"Hello {fname}");
                    }
                }
            } while (userAnswer.ToLower() == "yes");

            Console.ReadLine();
        }
    }
}
