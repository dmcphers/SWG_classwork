using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer.UI
{
    class ConsoleInput
    {
        public static int GetIntFromUser()
        {
            bool first = true;
            int result;
            string userInput;

            do
            {
                // If here a second or subsequent time, the input was
                // not valid
                if (!first)
                {
                    // bad input
                    Console.WriteLine("That is not a valid input.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                // Set first to false to cause error message to display
                // above on the next pass through the loop.
                first = false;

                // 1 & 2: Prompt and Read
                Console.Write("What number would you like to factor? ");
                userInput = Console.ReadLine();

                // attempt to convert - if fail, loop again
            } while (!int.TryParse(userInput, out result));
            return result;
        }
    }
}
