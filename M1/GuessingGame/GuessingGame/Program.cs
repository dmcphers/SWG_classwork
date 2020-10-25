using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static int theAnswer;
        static void Main(string[] args)
        {
            string playerName;
            string playerLevel;
            bool invalidInput = true;
            
            int levelMax;
            string playerInput;
            int playerGuess;
            
            int answerCount = 0;

            Random r = new Random();
            
   
            // get player input
            Console.WriteLine("Hello and welcome to the Guessing Game. Please enter your name: ");
            playerName = Console.ReadLine();
           
            Console.WriteLine("Hello " + playerName + " For easy level, type 1. For medium level, type 2. For hard level, type 3.");
           
            do
            {
                playerLevel = Console.ReadLine();
                if (playerLevel == "1")
                {
                    theAnswer = r.Next(1, 6);
                    invalidInput = false;
                }
                else if (playerLevel == "2")
                {
                    theAnswer = r.Next(1, 21);
                    invalidInput = false;
                }
                else if (playerLevel == "3")
                {
                    theAnswer = r.Next(1, 51);
                    invalidInput = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid choice, please type 1 for easy level, 2 for medium level, and 3 for hard level.");
                    Console.ResetColor();
                }

            } while (invalidInput == true);

            if (playerLevel == "1")
            {
                levelMax = 5;
            }
            else if (playerLevel == "2")
            {
                levelMax = 20;
            }
            else
            {
                levelMax = 50;
            }

            Console.WriteLine($"Please type a number between 1 and {levelMax} or press Q to quit");

            do
            {
                playerInput = Console.ReadLine();
                if (playerInput.ToUpper() == "Q")
                {
                    break;
                }

                //attempt to convert the string to a number
                if (int.TryParse(playerInput, out playerGuess))
                {
                    answerCount++;
                    if (playerGuess == theAnswer)
                    {
                        if (answerCount == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"You are an amazing guesser {playerName}! You guessed it on your first try!");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Great job {playerName}! {theAnswer} was the number.  You Win!");
                            Console.WriteLine($"It took you {answerCount} tries to guess the answer.");
                            Console.ResetColor();
                            break;
                        }
                    }
                    else
                    {
                        if (playerGuess > theAnswer)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Your guess was too High {playerName}! Please try again or press Q key to quit.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Your guess was too low {playerName}! Please try again or press Q key to quit");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"That wasn't a number {playerName}! Please try again or press Q key to quit");
                    Console.ResetColor();
                }

            } while (true);

            Console.WriteLine("Press any key to exit the program.");
            Console.ReadLine();
           
        }
    }
}
