using System;

namespace LuckySevens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many dollar would you like to bet?");
            string strUserDollars = Console.ReadLine();
            double dblUserDollars = double.Parse(strUserDollars);
            int numRolls = 0;
            double maxAmount = 0;
            int maxAmountRolls = 0;
            Random roll = new Random();
            while (dblUserDollars > 0)
            {
               
                int dieOne = roll.Next(1, 7);
                int dieTwo = roll.Next(1, 7);
                if (dieOne + dieTwo == 7)
                {
                    dblUserDollars = dblUserDollars + 4;
                    numRolls++;
                    if (dblUserDollars > maxAmount)
                    {
                        maxAmount = dblUserDollars;
                        maxAmountRolls = numRolls;
                    }
                }
                else
                {
                    dblUserDollars = dblUserDollars - 1;
                    numRolls++;
                }
            }

            Console.WriteLine($"It took {numRolls} rolls for you to lose all your money");
            Console.WriteLine($"The most money you had at one time was {maxAmount}");
            Console.WriteLine($"You had rolled {maxAmountRolls} times at that point");
            Console.ReadLine();
        }
    }
}
