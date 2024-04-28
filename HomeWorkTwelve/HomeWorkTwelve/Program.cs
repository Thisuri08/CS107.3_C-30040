using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTwelve
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List <string> families = new List<string>();
            string answer;
            int memberNo;
            int total = 0;

            do
            {
               

                families.Add(FamilyList());

                memberNo = NumberOfMembers();

                Console.WriteLine("Are there any other family to attend ? ");
                answer = Console.ReadLine();
                
                Console.WriteLine();

                if(answer.ToLower() == "no")
                {
                  
                    Console.WriteLine("The list of the families that attend :");
                    Console.WriteLine();

                    foreach(string family in families)
                    {
                        Console.WriteLine(family);
                    }
                }

            } while (answer.ToLower() == "yes");

            for (int i = 0; i < families.Count; i++)  
            {
                total += memberNo;
            }
            Console.WriteLine($"There were {total} members of people in the party.");
            Console.WriteLine();



            Console.ReadLine();
        }

        public static string FamilyList()
        {
            Console.WriteLine("--- WELCOME TO THE PARTY !!! ---");
            Console.WriteLine();

            Console.WriteLine("What family you are? ");
            string family = Console.ReadLine();

            return family;
        }

        public static int NumberOfMembers()
        {
            Console.WriteLine("How many memebers are there in your family? ");
            int MemberNo = Convert.ToInt32(Console.ReadLine());
            return MemberNo;
            
        }
      
        
    }
}
