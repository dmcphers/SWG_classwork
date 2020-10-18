using System;

namespace Factorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What number would you like to factor? ");
            string strNum = Console.ReadLine();
            Console.WriteLine("The factors of " + strNum + " are:");

            bool intNum = false;
            intNum = Int32.TryParse(strNum, out int userNum);
            int counter = 0;

            do
            {
                if (intNum == true)
                {
                    for (int i = 1; i <= userNum; i++)
                    {
                        if (userNum % i == 0)
                        {
                            Console.Write(i + " ");
                            counter++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid number, please try again");
                }

            } while (intNum == false);

            Console.WriteLine();
            Console.WriteLine("The number " + userNum + " has " + counter + " factors");

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

            int sum = 0;
            for (int i = 0; i < factors.Length - 1; i++)
            {
                sum += factors[i];
                if (sum == userNum)
                {
                    Console.WriteLine(userNum + " is a perfect number");
                }
            }

            if ((factors[0] == 1) && (factors[1] == userNum))
            {
                Console.WriteLine(userNum + " is a prime number");
            }

            Console.ReadLine();
        }
    }
}
