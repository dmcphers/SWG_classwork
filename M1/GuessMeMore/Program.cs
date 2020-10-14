using System;

namespace GuessMeMore
{
    class Program
    {
        static void Main(string[] args)
        {
            int secNumber = -27;
            string userGuess;
            bool isValid = false;


            Console.WriteLine("I've chosen a signed integer number between -100 and 100. Bet you can't guess it!");
            do
            {
                userGuess = Console.ReadLine();

                isValid = Int32.TryParse(userGuess, out int guess);
                if (isValid == true)
                {
                    if (guess == secNumber)
                    {
                        Console.WriteLine("That was it, congratulatons!");
                    }
                    else if (guess < secNumber)
                    {
                        Console.WriteLine("Your guess is too low. Try again!");
                        isValid = false;
                    }
                    else
                    {
                        Console.WriteLine("Your guess is too high. Try again!");
                        isValid = false;
                    }
                }
                else
                {
                    Console.WriteLine("That was not a signed integer value between -100 and 100, please try again.");
                }
            } while (isValid == false);

            Console.ReadLine();
        }
    }
}
