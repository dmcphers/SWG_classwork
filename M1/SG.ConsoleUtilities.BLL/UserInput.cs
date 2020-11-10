using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG.ConsoleUtilities.BLL
{
    public class UserInput
    {
        public static int GetIntFromUser(string prompt)
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
                }

                // Set first to false to cause error message to display
                // above on the next pass through the loop.
                first = false;

                // 1 & 2: Prompt and Read
                Console.Write(prompt);
                userInput = Console.ReadLine();

                // attempt to convert - if fail, loop again
                // (note the '!' in front of the int.TryParse)
            } while (!int.TryParse(userInput, out result));

            return result;
        }
    }
}
