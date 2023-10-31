using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Number_Guesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool guessedcorrect = false;
            Random random = new Random();
            int highscore = 10000;
            int trys = 0;
            int maximal = 100;
            string anothergame = "Y";
            int userNumber = 0;
            bool numberset = false;

            Console.WriteLine("Welcome to the Number-Guesser-Game");
            Thread.Sleep(500);
            Console.WriteLine("Try to guess it as fast as possible");
            Thread.Sleep(500);

            do
            {
                guessedcorrect = false;
                trys = 0;
                Console.WriteLine("Now Set your guess range from 1 to x: ");
                do
                {
                    try
                    {
                        maximal = Convert.ToInt32(Console.ReadLine());
                        if (maximal > 0)
                        {
                            numberset = true;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Input. Please try again");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Incorrect Input. Please try again");
                    }
                } while (numberset == false);

                int randomnumber = random.Next(1, maximal);

                Thread.Sleep(500);
                Console.WriteLine("Your random number is now generated.");
                Thread.Sleep(500);
                Console.WriteLine("Good Luck!");
                Thread.Sleep(500);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("First try (c_c)/ {?}");
                while (!guessedcorrect)
                {
                    string userInput = Console.ReadLine();

                    try
                    {
                        userNumber = Convert.ToInt32(userInput);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect Inpqut. Please try again");
                    }

                    if (userNumber > randomnumber && userNumber <= maximal)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Your Guess was too high");
                        Console.WriteLine("Try again (o_o) ");
                    }
                    else if (userNumber < randomnumber && userNumber >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Your Guess was too low");
                        Console.WriteLine("Try again (o_o) ");
                    }
                    else if (userNumber == randomnumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(":O");
                        guessedcorrect = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your Number is not in the guessing range :U");
                        Console.WriteLine("Try again (o_o) ");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    trys++;
                    Thread.Sleep(500);
                }

                if (trys < highscore)
                {
                    highscore = trys;
                }
                Thread.Sleep(500);
                Console.WriteLine("Congratulatoin, you guessed the correct number.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(500);
                Console.WriteLine("The coorect number was " + randomnumber);
                Thread.Sleep(500);
                Console.WriteLine("It took you " + trys + " " + "trys go guess it");
                Thread.Sleep(500);
                Console.WriteLine("Your record was " + highscore + " " + "trys");
                Thread.Sleep(500);
                Console.WriteLine("Would you like to play again? [Y]");
                Thread.Sleep(500);

                anothergame = Console.ReadLine();

            } while (anothergame == "Y");
        }
    }
}
