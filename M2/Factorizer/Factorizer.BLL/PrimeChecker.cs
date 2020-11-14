using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer.BLL
{
    public class PrimeChecker
    {
        public bool CheckIfPrime(int[] factors, int userNum)
        {
            if ((factors[0] == 1) && (factors[1] == userNum))
            {
                //Console.WriteLine(userNum + " is a prime number");
                return true;
            }
            return false;
        }
         
    }
}
