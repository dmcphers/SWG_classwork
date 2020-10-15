using System;

namespace LazyTeenager
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, chance = 0;
            do
            {
                Random rnd = new Random();
                int rndCheck = rnd.Next(0, 101);
                counter++; chance += 10;

                Console.WriteLine("Clean your room!! (x" + counter + ")");

                if (rndCheck <= (chance))
                {
                    Console.Write("Fine, I'll clean my room.  BUT I REFUSE TO WASH THE DISHES!");
                    break;
                }
               
                else if (counter == 7)
                {
                    Console.WriteLine("That's IT, I'M doing IT!!! YOU'RE GROUNDED AND I'M TAKING YOUR XBOX!");
                    break;
                }

            } while (counter < 10);

            Console.ReadLine();
        }
    }
}
