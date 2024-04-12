using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name?");
            string name = Console.ReadLine();

            if(name.ToLower() == "tish")
            {
                Console.WriteLine("Hello professor");
            }
            else if (name.ToLower() == "sue")
            {
                Console.WriteLine("Hello Sue");
            }
            else
            {
                Console.WriteLine("hello student");
            }

            Console.WriteLine();
            Console.Write("Enter your first name: ");
            string firstName= Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();

            if(firstName.ToLower() == "tish" &&  lastName.ToLower() == "gamage")
            {
                Console.WriteLine("you have a such a nice name ");
            }
            if (lastName.ToLower() == "gamage")
            {
                Console.WriteLine("your last name is handy");
            }
            if (firstName.ToLower() == "tish")
            {
                Console.WriteLine("your first name is unique , you are lucky");
            }
            else
            {
                Console.WriteLine("your name is not that pretty");
            }


            Console.WriteLine("Enter your age? ");
            int age = Convert.ToInt32(Console.ReadLine());

            switch (age)
            {
                case 18:
                    Console.WriteLine("you are young");
                    break;
                case 20:
                    Console.WriteLine("you are in your 20's");
                    break;
                default:
                    Console.WriteLine("you must have done with your studies");
                    break;

            }
            Console.ReadLine();
        }
    }
}
