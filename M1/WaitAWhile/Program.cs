using System;

namespace WaitAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeNow = 5; 
            //int timeNow = 11;  // when timeNow is set to 11, loop will not run since timeNow is > bedTime
            int bedTime = 10;
            //int bedTime = 11; // when bedtime is set to 11, loop will exit when timenow is 12


            while (timeNow < bedTime)
            {
                Console.WriteLine("It's only " + timeNow + " o'clock!");
                Console.WriteLine("I think I'll stay up just a little longer....");
                timeNow++; // Time passes - if timeNow is commented out, loop will run infinitely since timeNow will continue to be
                            // less than bedTime
            }

            Console.WriteLine("Oh. It's " + timeNow + " o'clock.");
            Console.WriteLine("Guess I should go to bed ...");
            Console.ReadLine();
        }
    }
}
