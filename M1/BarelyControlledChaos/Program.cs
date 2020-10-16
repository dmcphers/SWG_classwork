using System;

namespace BarelyControlledChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            string color = RandomColor(randomizer); // call color method here
            string animal = RandomAnimal(randomizer); // call animal method again here
            string colorAgain = RandomColor(randomizer); // call color method again here
            int weight = RandomNumber(randomizer, 5, 200); // call number method,
                                                            // with a range between 5 - 200
            int distance = RandomNumber(randomizer, 10, 20);// call number method,
                                                             // with a range between 10 - 20
            int number = RandomNumber(randomizer, 10000, 20000); // call number method,
                                                                 // with a range between 10000 - 20000
            int time = RandomNumber(randomizer, 2, 6); // call number method,
                                                         // with a range between 2 - 6            

            Console.WriteLine("Once, when I was very small...");

            Console.WriteLine("I was chased by a " + color + ", "
                + weight + "lb " + " miniature " + animal
                + " for over " + distance + " miles!!");

            Console.WriteLine("I had to hide in a field of over "
                + number + " " + colorAgain + " poppies for nearly "
                + time + " hours until it left me alone!");

            Console.WriteLine("\nIt was QUITE the experience, "
                + "let me tell you!");
        }
        // ??? Method 1 ???
        public static string RandomColor(Random randomInstance)
        {
            int randomColor = randomInstance.Next(1, 6);

            if (randomColor == 1)
            {
                return "red";
            }
            else if (randomColor == 2)
            {
                return "green";
            }
            else if (randomColor == 3)
            {
                return "blue";
            }
            else if (randomColor == 4)
            {
                return "yellow";
            }
            else
            {
                return "orange";
            }
        }
        // ??? Method 2 ???
        public static string RandomAnimal(Random randomInstance)
        {
            int randomAnimal = randomInstance.Next(1, 6);

            if (randomAnimal == 1)
            {
                return "baboon";
            }
            else if (randomAnimal == 2)
            {
                return "skink";
            }
            else if (randomAnimal == 3)
            {
                return "lemur";
            }
            else if (randomAnimal == 4)
            {
                return "rooster";
            }
            else
            {
                return "rhino";
            }
        }
        // ??? Method 3 ???
        public static int RandomNumber(Random randomInstance, int num1, int num2)
        {
            int randomNumber = randomInstance.Next(num1, num2 + 1);

            return randomNumber;
        }
    }
}
