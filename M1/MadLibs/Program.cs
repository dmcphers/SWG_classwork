using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to a Mad Lib Game! Let's Play!");
            Console.WriteLine();
            Console.WriteLine("Enter a noun:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter an adjective:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter a noun:");
            string input3 = Console.ReadLine();
            Console.WriteLine("Enter a number:");
            string input4 = Console.ReadLine();
            Console.WriteLine("Enter an adjective:");
            string input5 = Console.ReadLine();
            Console.WriteLine("Enter a plural noun:");
            string input6 = Console.ReadLine();
            Console.WriteLine("Enter a plural noun:");
            string input7 = Console.ReadLine();
            Console.WriteLine("Enter a plural noun:");
            string input8 = Console.ReadLine();
            Console.WriteLine("Enter a present tense verb:");
            string input9 = Console.ReadLine();
            Console.WriteLine("Enter same verb but past tense:");
            string input10 = Console.ReadLine();

            Console.WriteLine("Here is your amazing story! ");
            Console.WriteLine();
            Console.WriteLine($"{input1}: the {input2} frontier. These are the voyages of the starship {input3}. " +
                $"Its {input4} -year mission: to explore strange {input5} {input6}, to seek out {input5} {input7} and {input5} {input8}, " +
                $"to boldly {input9} where no one has {input10} before.");

            Console.ReadLine();
        }
    }
}
