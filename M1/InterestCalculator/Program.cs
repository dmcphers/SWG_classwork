using System;

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the initial amount of principal:");
            string userStrPrincipal = Console.ReadLine();

            Console.WriteLine("Please enter the annual interest rate:");
            string userStrAnnualRate = Console.ReadLine();

            Console.WriteLine("Please enter the number of years for money to stay in the fund:");
            string userStrYearsInvested = Console.ReadLine();

            decimal userDecAnnualRate = decimal.Parse(userStrAnnualRate);
            decimal userQuarterlyRate = userDecAnnualRate / 4;
            decimal userYrStartBalance = decimal.Parse(userStrPrincipal);
            int userIntYearsInvested = int.Parse(userStrYearsInvested);
            decimal userEndBal = 0;
            decimal userQtrStartBalance = 0;

            for (int i = 1; i <= userIntYearsInvested; i++)
            {
                Console.WriteLine($"Year {i}");
                Console.WriteLine($"Began with {userYrStartBalance}");
                userQtrStartBalance = userYrStartBalance;

                for (int j = 1; j <= 4; j++)
                {
                    userEndBal = Math.Round((userQtrStartBalance * (1 + (userQuarterlyRate / 100))) , 2);
                    userQtrStartBalance = userEndBal;
                }

                // userEndBal = userYrStartBalance * (1 + (userQuarterlyRate / 100));

                decimal interest = userEndBal - userYrStartBalance;
                Console.WriteLine($"Earned {interest}");
                Console.WriteLine($"Ended with {userEndBal}");
                userYrStartBalance = userEndBal;
               
                Console.WriteLine();
            }
        }
    }
}
