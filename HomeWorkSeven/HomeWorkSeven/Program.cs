using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if we need to keep adding items to the list , then we can't let it reset
            // in order to avoid reseting we need to keep the list out of the loop
            string answer;
            List<string> classRoster = new List<string>();

            do
            {
                Console.WriteLine("Enter the student name? ");
                string name = Console.ReadLine();

                
                classRoster.Add(name);

                Console.WriteLine(@"are there're still students to be in the class list? (yes/no)");
                answer = Console.ReadLine();

                if (answer.ToLower() == "no")
                {
                    Console.WriteLine("that's all the students we have.");
                    Console.WriteLine($"and it is {classRoster.Count} number of students");

                }
            } while (answer.ToLower() == "yes");

            Console.ReadLine();
        }
    }
}
