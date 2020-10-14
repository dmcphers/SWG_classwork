using System;

namespace MiniZork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are standing in an open field west of a white house,");
            Console.WriteLine("with a boarded front door.");
            Console.WriteLine("There is a small mailbox here.");
            Console.WriteLine("You are also east of a brown house,");
            Console.WriteLine("that looks old and deserted.");
            Console.WriteLine("There is a small shed to the side of the brown house that has the door cracked slightly open.");
            bool isInvalid = true;

            do
            {
                Console.Write("go to the white house, open the mailbox, go to the brown house, or go look in the shed? ");

                String action = Console.ReadLine();

                if (action.Equals("open the mailbox"))
                {
                    isInvalid = false;
                    Console.WriteLine("You open the mailbox.");
                    Console.WriteLine("It's really dark in there.");
                    Console.Write("Look inside or stick your hand in? ");
                    action = Console.ReadLine();

                    if (action.Equals("look inside"))
                    {
                        Console.WriteLine("You peer inside the mailbox.");
                        Console.WriteLine("It's really very dark. So ... so very dark.");
                        Console.Write("Run away or keep looking? ");
                        action = Console.ReadLine();

                        if (action.Equals("keep looking"))
                        {
                            Console.WriteLine("Turns out, hanging out around dark places isn't a good idea.");
                            Console.WriteLine("You've been eaten by a grue.");
                           
                        }
                        else if (action.Equals("run away"))
                        {
                            Console.WriteLine("You run away screaming across the fields - looking very foolish.");
                            Console.WriteLine("But you're alive. Possibly a wise choice.");
                        }
                    }
                    else if (action.Equals("stick your hand in"))
                    {
                        Console.WriteLine("You begin to stick your hand in the dark mailbox,");
                        Console.WriteLine("it is cold and damp when you come upon something solid.");
                        Console.WriteLine("Grab it and take it out, or run away?");
                        action = Console.ReadLine();

                        if (action.Equals("grab it and take it out"))
                        {
                            Console.WriteLine("What an amazing stroke of good luck, you have pulled out a bar of gold");
                            Console.WriteLine("worth 1 million dollars!");
                        }
                        else if (action.Equals("run away"))
                        {
                            Console.WriteLine("You run away screaming across the fields - where a bear chases you down and mauls you.");
                            Console.WriteLine("Oops guess that was the wrong choice.");
                        }
                    }
                }
                else if (action.Equals("go to the white house"))
                {
                    isInvalid = false;
                    Console.WriteLine("You go up to an open window of the white house.");
                    Console.WriteLine("It's really dark in there.");
                    Console.Write("Look inside or run away? ");
                    action = Console.ReadLine();

                    if (action.Equals("look inside"))
                    {
                        Console.WriteLine("You peer inside.");
                        Console.WriteLine("It's really very dark. So ... so very dark.");
                        Console.WriteLine("Turns out, peering in dark places isn't a good idea.");
                        Console.WriteLine("You've been sucked into a giant whirlpool.");
                    }
                    else if (action.Equals("run away"))
                    {
                        Console.WriteLine("You run away screaming across the fields - looking very foolish.");
                        Console.WriteLine("But you're alive. Possibly a wise choice.");
                    }
                }
                else if (action.Equals("go to the brown house"))
                {
                    isInvalid = false;
                    Console.WriteLine("You hear something creaking behind the back of the house.");
                    Console.Write("go check it out or run away? ");
                    action = Console.ReadLine();

                    if (action.Equals("go check it out"))
                    {
                        Console.WriteLine("You cautiously approach the corner of the house and begin to peer around the corner when...");
                        Console.WriteLine("You finally look and...it turns out to be an old branch rubbing across the side of the house making a creaking noise.");
                        Console.WriteLine("Well, not too exciting, but at least you're alive.");
                    }
                    else if (action.Equals("run away"))
                    {
                        Console.WriteLine("You run away screaming across the fields - where you are caught in a rainstorm and struck by lightning.");
                        Console.WriteLine("Oops, should have investigated that creaking behind the house.");
                    }
                }
                else if (action.Equals("go look in the shed"))
                {
                    isInvalid = false;
                    Console.WriteLine("You go up to the door of the shed that is slightly open.");
                    Console.WriteLine("You hear someone giggling lightly like a small child.");
                    Console.Write("Look inside or run away? ");
                    action = Console.ReadLine();

                    if (action.Equals("look inside"))
                    {
                        Console.WriteLine("You cautiously peer inside the little shed...");
                        Console.WriteLine("all of the sudden you are sucked into the shed where you must stay in darkness forever.");
                        Console.WriteLine("Probably should have resisted your curiousity there.");
                    }
                    else if (action.Equals("run away"))
                    {
                        Console.WriteLine("You run away screaming across the fields - looking very foolish.");
                        Console.WriteLine("But you're alive. Possibly a wise choice.");
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid choice - please try again.");
                }
            } while (isInvalid == true);

            Console.ReadLine();
        }
    }
}
