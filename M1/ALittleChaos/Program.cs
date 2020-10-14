using System;

namespace ALittleChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            Console.WriteLine("Random can make integers: " + randomizer.Next());
            Console.WriteLine("Or a double: " + randomizer.NextDouble());

            //int num = randomizer.Next(101);
            int num = randomizer.Next(51) + 50; //the value of num will work just like it does with the previous line
            
            

            Console.WriteLine("You can store a randomized int result: " + num);
            Console.WriteLine("And use it over and over again: " + num + ", " + num);


            Console.WriteLine("Or just keep generating new int values");
            Console.WriteLine("Here's a bunch of int numbers from 0 - 100: ");

            Console.WriteLine(randomizer.Next(101) + ",");
            Console.WriteLine(randomizer.Next(101) + ",");
            Console.WriteLine(randomizer.Next(101) + ",");
            Console.WriteLine(randomizer.Next(101) + ",");
            Console.WriteLine(randomizer.Next(101) + ",");
            Console.WriteLine(randomizer.Next(101));

            num = num + 100;
            Console.WriteLine("Value of num used in a math statement: " + num);  // random numbers can be included in a math statement

            double num2 = randomizer.NextDouble();
            Console.WriteLine("You can also store a randomized double result: " + num2);
            Console.WriteLine("And use it over and over again: " + num2 + ", " + num2);

            Console.WriteLine("Or just keep generating new double values");
            Console.WriteLine("Here's a bunch of double numbers from 0 - 1: ");

            Console.WriteLine(randomizer.NextDouble() + ",");
            Console.WriteLine(randomizer.NextDouble() + ",");
            Console.WriteLine(randomizer.NextDouble() + ",");
            Console.WriteLine(randomizer.NextDouble() + ",");
            Console.WriteLine(randomizer.NextDouble() + ",");
            Console.WriteLine(randomizer.NextDouble());



        }
    }
}
