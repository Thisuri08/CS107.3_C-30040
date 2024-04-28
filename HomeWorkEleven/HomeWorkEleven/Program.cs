using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkEleven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WellcomeMsg();

           string name = UserName();

            SayHi(name);

            Console.ReadLine();

        }

        public static void WellcomeMsg()
        {
            Console.WriteLine("Wellcome to our application!");
        }

        public static string UserName()
        {
            Console.WriteLine("Enter your first name? ");
            string name = Console.ReadLine();
            return name;
        }

        public static void SayHi(string name) {

            Console.WriteLine($"Hello {name}");

        }
    }
}
