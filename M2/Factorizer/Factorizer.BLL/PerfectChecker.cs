using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer.BLL
{
    public class PerfectChecker
    {
        public bool CheckIfPerfect(int[] factors, int userNum)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length - 1; i++)
            {
                sum += factors[i];
                if (sum == userNum)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
