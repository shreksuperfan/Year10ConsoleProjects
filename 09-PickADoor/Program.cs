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


            /* 2. Use selection (if...else if...else) to print what is behind
             *    each door. Make sure to print a warning message if the user 
             *    picks something other than 1, 2 or 3.                       */
            


            // Wait at the end
            Console.ReadLine();

        }

        static void ExtensionTasks()
        {
            // 1. Use more else if's to create more doors
            // 2. Use what you have learnt to create a customised message to the user (e.g. with their name)
            // 3. Use Google to figure out how to choose a random number. Make this the only door with a prize
        }

        static void Questions()
        {
            // 1. What is the purpose of the ELSE statement in this program?
            // 
            // 
            // 2. What is the purpose of Pseudocode?
            // 
            // 
        }

        static void ExampleOutput()
        {
            // This is an example of the program's output:
            // 
            // Pick a Door: 1, 2 or 3
            // 2
            // You win a Car!
        }

        static void Pseudocode()
        {
            /* 
                BEGIN
                    PRINT "Pick a Door: 1, 2 or 3"
                    INPUT choice
                    IF choice = 1 THEN
                        PRINT "You win a Boat!"
                    ELSE IF choice = 2 THEN
                        PRINT "You win a Car!"
                    ELSE IF choice = 3 THEN
                        PRINT "You win $10,000!"
                    ELSE
                        PRINT "That door doesn't exist!"
                    END IF
                END             
             */ 
              
        }
    }
}
