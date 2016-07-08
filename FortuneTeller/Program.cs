using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name");
            string fName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is your last name");
            string lName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("What month were you born?");
            string bMonth = Console.ReadLine();
            Console.Clear();

            string fColor;
            Console.WriteLine("What's your favorite ROYGBIV color? Type HELP if you don't know what this means.");
            fColor = Console.ReadLine();
            Console.Clear();
            while (fColor.ToUpper() == "HELP")
            {
                Console.WriteLine("ROYGBIV is an acronym for the colors of the rainbow.");
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, and Violet, respectively.");
                Console.WriteLine("So, which is your favorite?");
                fColor = Console.ReadLine();
            }

            Console.WriteLine("How many siblings do you have?");
            int numSibs = int.Parse(Console.ReadLine());
            Console.Clear();

            
        }
    }
}
