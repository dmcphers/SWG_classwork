using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer.UI
{
    class ConsoleOutput
    {
        public static void DisplayTitle()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Better, Testable, Factorizer!\n\n");
            PressKeyToContinue("Press any key to start the game...");
        }

        //
        // Best practice: Use helper function to avoid duplicate code.
        //

        /// <summary>
        /// PressKeyToContinue - display prompt and wait for Console key input
        /// </summary>
        /// <param name="prompt">Message to display for prompt. If none specified, display
        /// default "Press any key to continue...". Uses C# optional parameter with default value</param>
        public static void PressKeyToContinue(string prompt = "Press any key to continue...")
        {
            Console.WriteLine(prompt);
            Console.ReadKey();
        }

        public static void DisplayFactorizeMessage(int userNumber, int[] factors, bool isPerfect, bool isPrime)
        {
            Console.WriteLine($"The factors of {userNumber} are: ");
            for (int i = 0; i < factors.Length; i++)
            {
                Console.Write(factors[i] + " ");
            }
            Console.WriteLine();
            if (isPerfect == false)
            {
                Console.WriteLine($"{userNumber} is not a perfect number!");
            }
            else
            {
                Console.WriteLine($"{userNumber} is a perfect number!");
            }

            if (isPrime == false)
            {
                Console.WriteLine($"{userNumber} is not a prime number!");
            }
            else
            {
                Console.WriteLine($"{userNumber} is a prime number!");
            }

            PressKeyToContinue();
        }
    }
}
