using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keepGoing;
            do
            {
                Console.WriteLine("Enter your name?");
                string name = Console.ReadLine();

                if (name.ToLower() == "tim")
                {
                    Console.WriteLine("hey,professor Tim");
                }
                else
                {
                    Console.WriteLine("hey, student!!");
                }

                Console.WriteLine(@"Do you want to continue? (yes/no)");
                keepGoing = Console.ReadLine();

                if (keepGoing.ToLower() == "no")
                {
                    Console.WriteLine("thank you for using our website,bye!");
                   
                }

            } while (keepGoing.ToLower() == "yes");

            Console.ReadLine();
        }
    }
}
