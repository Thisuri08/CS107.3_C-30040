using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your age? ");
                string ageText = Console.ReadLine();

                bool validAge = int.TryParse(ageText, out int Age);

                string FormattedName;

                if (validAge)
                {
                    if (name.ToLower() == "bob" ||  name.ToLower() == "sue")
                    {
                        FormattedName = $"Professor {name}";
                    }
                    else
                    {
                        FormattedName = name;
                    }

                    if (Age < 21)
                    {
                        Console.WriteLine($"Have to wait {21- Age} years to enroll this course {FormattedName}");
                    }
                    else
                    {
                        Console.WriteLine($"You can access the course,{FormattedName}");
                    }

                }
            else
            {
                Console.WriteLine("you have entered an invalid age,try again.");
            }

            Console.ReadLine();


         
        }


    }
}
