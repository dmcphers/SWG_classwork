using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Let's play a FizzBuzz game. Please type a number: ");
           
            bool isValid = false;
            
            do
            {
                string userNum = Console.ReadLine();
                isValid = Int32.TryParse(userNum, out int choice);
                if (isValid == true)
                {
                    for (int i = 1; i <= choice; i++)
                    {
                        if (i == choice)
                        {
                            Console.WriteLine("TRADITION!!!!!");
                        }
                        else if (i % 3 == 0 && i % 5 == 0)
                        {
                            Console.WriteLine("fizz buzz");
                        }
                        else if (i % 3 == 0)
                        {
                            Console.WriteLine("fizz");
                        }
                        else if (i % 5 == 0)
                        {
                            Console.WriteLine("buzz");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That was not a valid number - please try again.");
                }
            } while (isValid == false);            
        }
    }
}
