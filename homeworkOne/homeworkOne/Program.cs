using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(  "Enter your name?");
            string name = Console.ReadLine();
            Console.Write("Enter your age?");
            int age =Convert.ToInt32(Console.ReadLine());
            Console.Write("Are you alive or not?");
            bool alive = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Enter your phone number?");
            string phoneNo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"your name is {name}");
            Console.WriteLine($"Your age is {age}");
            Console.WriteLine($"you are alive: {alive}");
            Console.WriteLine($@"Your phone number is {phoneNo}");

            Console.ReadLine();
        }
    }
}
