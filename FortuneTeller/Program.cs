using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Quitter(string quitRestart)
        {
            if (quitRestart.ToUpper() == "QUIT")
            {
                Console.WriteLine("Nobody likes a quitter...");
                
            }
        }
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
                string quitRestart = fName;
                Quitter(quitRestart);
                Console.Clear();
                Console.WriteLine("What is your last name");
                string lName = Console.ReadLine();
                quitRestart = lName;
                Quitter(quitRestart);
                Console.Clear();
                string age;
                int iAge = -1;
                do
                {
                    Console.WriteLine("How old are you?");
                    // what if they don't give a number?
                    try
                    {
                        age = (Console.ReadLine());
                        quitRestart = age;
                        Quitter(quitRestart);
                        iAge = int.Parse(age);
                    }
                    catch (Exception e)

                    {
                        Console.WriteLine("That is not a valid number.");
                    }
                }
                while (iAge == -1);
                Console.Clear();
                Console.WriteLine("What month were you born?");
                string bMonth = Console.ReadLine();
                quitRestart = bMonth;
                Quitter(quitRestart);
                Console.Clear();
                //What if they don't know Roy?
                string fColor="Nothing";
                //do
                //{
                    Console.WriteLine("What's your favorite ROYGBIV color? Type HELP if you don't know what this means.");
                    fColor = Console.ReadLine();
                    fColor = fColor.ToUpper();
                quitRestart = fColor;
                Quitter(quitRestart);
                Console.Clear();
                    while (fColor.ToUpper() == "HELP")
                    {
                        Console.WriteLine("ROYGBIV is an acronym for the colors of the rainbow.");
                        Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, and Violet, respectively.");
                        Console.WriteLine("So, which is your favorite?");
                        fColor = Console.ReadLine();
                        fColor = fColor.ToUpper();
                    quitRestart = fColor;
                    Quitter(quitRestart);
                    Console.Clear();
                    }
                    //Catch non valid input??

                //}
                //while (fColor[0] != 'R' || fColor[0] != 'O' || fColor[0] != 'Y' || fColor[0] != 'G' || fColor[0] != 'B' || fColor[0] != 'I' || fColor[0] != 'V');
                //Now they know Roy.
                int numSibs = -1;
                string snumSibs;
                while (numSibs == -1)
                {
                    try
                    {
                        Console.WriteLine("How many siblings do you have?");
                        snumSibs = Console.ReadLine();
                        quitRestart = snumSibs;
                        Quitter(quitRestart);
                        numSibs = int.Parse(snumSibs);
                        Console.Clear();
                    }
                    catch (Exception e2)
                    {
                        Console.WriteLine("Please give a numerical response.");
                    }
                }

                //how long til they retire
                int retireAge;
                if (iAge % 2 == 0)
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
                //fColor = fColor.ToUpper();
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
                        fColor = "Airship";
                        break;
                    case 'I':
                        fColor = "Starship Enterprise";
                        break;
                    case 'V':
                        fColor = "Lion of Voltron";
                        break;
                    // You don't follow rules? Have a Rickshaw.
                    default:
                        fColor = "Rickshaw";
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
