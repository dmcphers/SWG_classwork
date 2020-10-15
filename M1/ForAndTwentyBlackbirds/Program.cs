using System;

namespace ForAndTwentyBlackbirds
{
    class Program
    {
        static void Main(string[] args)
        {
            int birdsInPie = 0;
            for (int i = 0; i < 24; i++)    // updated the stop condition from 20 to 24 so will now print out 24 lines and total
            {
                Console.WriteLine("Blackbird #" + i + " goes into the pie!");
                birdsInPie++;
            }

            Console.WriteLine("There are " + birdsInPie + " birds in there!");
            Console.WriteLine("Quite the pie full!");
            Console.ReadLine();
        }
    }
}
