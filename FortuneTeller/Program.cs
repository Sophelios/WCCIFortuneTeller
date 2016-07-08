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
            //assigning a variable
            int retWith=0;
            //let them play again
            string playAgain;
            do
                
            {
                //First collect all the super important personal info
                Console.WriteLine("What is your first name");
                string fName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What is your last name");
                string lName = Console.ReadLine();
                Console.Clear();
                int age = -1;
                while (age == -1)
                {
                    Console.WriteLine("How old are you?");
                    // what if they don't give a number?
                    try
                    {
                        age = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)

                    {
                        Console.WriteLine("That is not a valid number.");
                    }
                }
                Console.Clear();
                Console.WriteLine("What month were you born?");
                string bMonth = Console.ReadLine();
                Console.Clear();
                //What if they don't know Roy?
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
                    Console.Clear();
                    //Catch non valid input??
                    
                }
                //Now they know Roy.
                int numSibs = -1;
                while (numSibs == -1)
                {
                    try
                    {
                        Console.WriteLine("How many siblings do you have?");
                        numSibs = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    catch (Exception e2)
                    {
                        Console.WriteLine("Please give a numerical response.");
                    }
                }

                //how long til they retire
                int retireAge;
                if (age % 2 == 0)
                {
                    retireAge = 20;
                }
                else
                {
                    retireAge = 30;
                }
                //Where're ya gonna retire?
                string retireLoc;
                if (numSibs == 0)
                {
                    retireLoc = "The North";
                }
                else if (numSibs == 1)
                {
                    retireLoc = "Avenger's Tower";
                }
                else if (numSibs == 2)
                {
                    retireLoc = "Ilvermorny";
                }
                else if (numSibs == 3)
                {
                    retireLoc = "Casterly Rock";
                }
                else
                {
                    retireLoc = "Hogwarts";
                }

                //What will the retiree be driving?
                fColor = fColor.ToUpper();
                switch (fColor[0])
                {
                    case 'R':
                        fColor = "Dragon";
                        break;
                    case 'O':
                        fColor = "BroomStick";
                        break;
                    case 'Y':
                        fColor = "Glider";
                        break;
                    case 'G':
                        fColor = "X-Wing";
                        break;
                    case 'B':
                        fColor = "Rickshaw";
                        break;
                    case 'I':
                        fColor = "Starship Enterprise";
                        break;
                    case 'V':
                        fColor = "Lion of Voltron";
                        break;

                }
                //How much will they retire with
                bMonth = bMonth.ToUpper();
                if ((fName.ToUpper().IndexOf(bMonth[0]) > 0) || (lName.ToUpper().IndexOf(bMonth[0]) > 0))
                {
                    retWith = 1000000;
                }
                else if ((fName.ToUpper().IndexOf(bMonth[1]) > 0) || (lName.ToUpper().IndexOf(bMonth[1]) > 0))
                {
                    retWith = 9999999;
                }
                else if ((fName.ToUpper().IndexOf(bMonth[2]) > 0) || (lName.ToUpper().IndexOf(bMonth[2]) > 0))
                {
                    retWith = 10;
                }
                else
                {
                    retWith = 61531325;
                }
                Console.WriteLine($"{fName} {lName} will retire in {retireAge} years, with ${retWith} in the bank,\na vacation home in {retireLoc} and a {fColor}.");
                Console.WriteLine();
                Console.WriteLine("Would you like a new fortune?(YES/NO)");
                playAgain = Console.ReadLine();
            }
            while (playAgain.ToUpper() == "YES");
        }
    }
}
