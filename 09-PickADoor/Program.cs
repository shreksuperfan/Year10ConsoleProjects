using System;

namespace _09_PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to pick a door
            Console.WriteLine("Pick a Door: 1, 2 or 3");

            // 1. Input and store the result in a string variable
        string door = Console.ReadLine();

            /* 2. Use selection (if...else if...else) to print what is behind
                  each door. Make sure to print a warning message if the user 
                  picks something other than 1, 2 or 3.                       */
            if (door =="1")
            {
                Console.WriteLine("it's a goat");
            }

            else if (door == "2")
            {
                Console.WriteLine("it's famous east coast rapper biggie smalls");
            }

            else if (door == "3")
            {
                Console.WriteLine("Did you ever hear the tragedy of Darth Plagueis the Wise? I thought not.It's not a story the Jedi would tell you. It's a Sith legend.Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create life... He had such a knowledge of the dark side that he could even keep the ones he cared about from dying.The dark side of the Force is a pathway to many abilities some consider to be unnatural.He became so powerful... the only thing he was afraid of was losing his power, which eventually, of course, he did.Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep.Ironic, he could save others from death, but not himself.");
            }
            else
            {
                Console.WriteLine("between 1 and 3 please");
            }
            // Wait at the end
            Console.ReadLine();

        }
    }
}


/* ------------------------------------------------------------------------------------------ /

EXTENSION TASKS:

1. Use more else if's to create more doors
2. Use what you have learnt to create a customised message to the user (e.g. with their name)
3. Research online to figure out how to choose a random number. Make this the only door with a prize


QUESTIONS:
        
1. What is the purpose of the final ELSE statement in this program?
to account for any inputs outside the variables




EXAMPLE:

This is an example of the program's output:

  Pick a Door: 1, 2 or 3
  2
  You win a Car!


LINKS:
https://www.tutorialspoint.com/csharp/csharp_decision_making.htm
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else


WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers
   
/ ------------------------------------------------------------------------------------------ */