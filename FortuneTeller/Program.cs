using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        
        static int Quitter(string quitRestart)
        {
            if (quitRestart.ToUpper() == "QUIT")
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);
                return 0;
            }
            else if (quitRestart.ToUpper() == "RESTART")
            {
                return 1;            
            }
            return 0;
            
        }
        static void Main(string[] args)
        {
            //assigning a variable
            int retWith=0;
            //let them play again
            //need some variables
            string bMonth;
            string fName;
            string lName;
            string playAgain;
            string quitRestart;
            int restartcheck2;
            do
            {
                restartcheck2 = 0;
                //First collect all the super important personal info
                if (restartcheck2 == 0)
                {
                    Console.WriteLine("Welcome to the WeCanCodeIT Fortune Teller!!");
                    Console.WriteLine("Type (QUIT) to quit anytime. \nYou're not a quitter, are you?");
                    Console.WriteLine("Type (RESTART) at anytime to begin again. \nIn case you don't know yourself that well.");
                    Console.WriteLine("To start, what is your first name?");
                    fName = Console.ReadLine();
                    quitRestart = fName;
                    restartcheck2 = Quitter(quitRestart);
                    Console.Clear();
                }
                else
                {
                    fName = "null";
                }
                if (restartcheck2 == 0)
                {
                    Console.WriteLine("And your last name?");
                    lName = Console.ReadLine();
                    quitRestart = lName;
                    restartcheck2 = Quitter(quitRestart);
                    Console.Clear();
                }
                else
                {
                    lName = "null";
                }
                string age;
                int iAge = -1;
                if (restartcheck2 == 0)
                {


                    do
                    {
                        Console.WriteLine("How old are you?");
                        // what if they don't give a number?
                        try
                        {
                            age = (Console.ReadLine());
                            quitRestart = age;
                            restartcheck2 = Quitter(quitRestart);
                            if (restartcheck2 == 1)
                            {
                                break;
                            }
                            iAge = int.Parse(age);
                        }
                        catch (Exception e)

                        {
                            Console.WriteLine("Come on... I need a real number. /nHow old are you? Using numerals, please.");
                        }
                    }
                    while (iAge == -1);
                }
                Console.Clear();
                if (restartcheck2 == 0)
                {
                    Console.WriteLine("Great! So, what month were you born?");
                    bMonth = Console.ReadLine();
                    quitRestart = bMonth;
                    restartcheck2 = Quitter(quitRestart);
                }
                else
                {
                    bMonth = "null";
                }
                Console.Clear();
                //What if they don't know Roy?
                string fColor="Nothing";
                string colorCheck = "ROYGBIV";
                int z = -1;
                if (restartcheck2 == 0)
                {
                    do
                    {
                        Console.WriteLine("Got it. And what's your favorite ROYGBIV color? \nType HELP if you don't know what this means.");
                        fColor = Console.ReadLine();
                        fColor = fColor.ToUpper();
                        quitRestart = fColor;
                        restartcheck2 = Quitter(quitRestart);
                        Console.Clear();
                        while (fColor.ToUpper() == "HELP")
                        {
                            Console.WriteLine("ROYGBIV is an acronym for the colors of the rainbow.");
                            Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, and Violet, respectively.");
                            Console.WriteLine("So, I ask again, which is your favorite?");
                            fColor = Console.ReadLine();
                            fColor = fColor.ToUpper();
                            quitRestart = fColor;
                            restartcheck2 = Quitter(quitRestart);
                            Console.Clear();
                        }
                        //Catch non valid input??
                        z = colorCheck.IndexOf(fColor[0]);
                    }
                    while (z < 0);
                }
                //Now they know Roy.
                int numSibs = -1;
                string snumSibs;
                if (restartcheck2 == 0)
                {
                    while (numSibs == -1)
                    {
                        try
                        {
                            Console.WriteLine("Finally, how many siblings do you have?");
                            snumSibs = Console.ReadLine();
                            quitRestart = snumSibs;
                            restartcheck2 = Quitter(quitRestart);
                            if (restartcheck2 == 1)
                            {
                                break;
                            }
                            numSibs = int.Parse(snumSibs);
                            Console.Clear();
                        }
                        catch (Exception e2)
                        {
                            Console.WriteLine("Numbers please. How many siblings do you have?");
                        }
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
                Console.WriteLine("Wow. That was a lot of personal information. \nImagine what a dishonest computer program might do with all that... \nerr... onto your fortune!");
                Console.WriteLine($"{fName} {lName} will retire in {retireAge} years, with ${retWith} in the bank,\na vacation home in {retireLoc} and a {fColor}.");
                Console.WriteLine();
                if (restartcheck2 == 0)
                {
                    Console.WriteLine("Would you like a new fortune?(YES/NO)");
                    playAgain = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    playAgain = "YES";
                }
            }
            while (playAgain.ToUpper() == "YES");
        }
    }
}
