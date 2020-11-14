using Factorizer.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Factorizer.UI
{
    class FactorizerFlow
    {
        FactorFinder _factorFinder;
        PerfectChecker _perfectChecker;
        PrimeChecker _primeChecker;
        public void Factorize()
        {
            _factorFinder = new FactorFinder();
            _perfectChecker = new PerfectChecker();
            _primeChecker = new PrimeChecker();

            ConsoleOutput.DisplayTitle();
            Console.WriteLine();

            int userNumber = ConsoleInput.GetIntFromUser();
            int[] factors = (int[])_factorFinder.FindFactors(userNumber);
            bool isPerfect = _perfectChecker.CheckIfPerfect(factors, userNumber);
            bool isPrime = _primeChecker.CheckIfPrime(factors, userNumber);
            ConsoleOutput.DisplayFactorizeMessage(userNumber, factors, isPerfect, isPrime);

            //GuessResult result;

            //do
            //{
            //    int guess = ConsoleInput.GetGuessFromUser();
            //    result = _manager.ProcessGuess(guess);
            //    ConsoleOutput.DisplayGuessMessage(result);
            //} while (result != GuessResult.Victory);
        }
    }
}
