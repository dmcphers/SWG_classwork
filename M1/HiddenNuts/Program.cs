using System;

namespace HiddenNuts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hidingSpots = new string[100];
            Random squirrel = new Random();
            hidingSpots[squirrel.Next(0, hidingSpots.Length)] = "Nut";
            Console.WriteLine("The nut has been hidden ...");
            
            // Nut finding code should go here! 
            int hidingSpot = 0;

            for (int i = 0; i < hidingSpots.Length; i++)
            {
                if (hidingSpots[i] == "Nut")
                {
                    hidingSpot = i;
                }
            }
            Console.WriteLine("Found it! It's in spot # " + hidingSpot);
        }
    }
}
