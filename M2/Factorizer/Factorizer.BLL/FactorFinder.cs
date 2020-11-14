using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer.BLL
{
    public class FactorFinder
    {
        public Array FindFactors(int userNum)
        {
            int counter = 0;

            for (int i = 1; i <= userNum; i++)
            {
                if (userNum % i == 0)
                {
                    counter++;
                }
            }

            int[] factors = new int[counter];

            int factorIndex = 0;
            for (int i = 1; i <= userNum; i++)
            {
                if (userNum % i == 0)
                {
                    factors.SetValue(i, factorIndex);
                    factorIndex++;
                }
            }

            return factors;
        }
    }
}
