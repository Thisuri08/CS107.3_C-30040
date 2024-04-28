using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkEight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employee = new Dictionary<int, string>();
            string userAnswer;
            int id;
            string name;

            do
            {
                Console.Write("Enter your employee ID:");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your employee name:");
                name = Console.ReadLine();

                employee.Add(id, name);

                Console.WriteLine(@"Is there any other employee to add (yes/no)? ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "no")
                {
                    Console.WriteLine("You are welcome to work with us!");
                }
            } while (userAnswer.ToLower() == "yes");

            Console.WriteLine("Enter user id of employee you want to find? ");
            int idSearch = Convert.ToInt32(Console.ReadLine());

            // the loop has to irratate over the keys of dictionary

            foreach (int key in employee.Keys)
            {
                if(idSearch == key)
                {
                    Console.WriteLine($"the employee of {idSearch} is {employee[key]}");
                    break;
                }
                else
                {
                    Console.WriteLine("there isn't any employee related to this id.");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
