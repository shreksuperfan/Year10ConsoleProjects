using System;

namespace _11_AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1. Area of Circle");
            Console.WriteLine("2. Area of Rectangle");
            Console.WriteLine("3. Area of Triangle");
            string choice = Console.ReadLine();

            // 1. Finish of the selection below. It needs to have pathways for the rectangle, triangle and invalid inputs
            // Area of rectangle = width * length. Area of Triangle = width * height * 0.5
            if (choice == "1")
            {
                // Area of Circle
                Console.WriteLine();
                Console.Write("Radius: ");
                float radius = float.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + (Math.PI * radius * radius));
            }


            // Wait
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void ExampleOutput()
        {
            // This is an example of the program's output:
            // 
            // Choose an Option:
            // 1. Area of Circle
            // 2. Area of Rectangle
            // 3. Area of Triangle
            // 
            // 2
            // 
            // Enter Width: 3
            // Enter Height: 4
            //
            // The area of the rectangle is 12
            // 
            // "Press any key to continue...
        }

        static void Pseudocode()
        {
            // Try writing the pseudocode for this one yourself
            // Refer to past examples if you get stuck

            /* 
                BEGIN
                    
                    
                    
                    
                    
                    
                    
                END             
             */

        }
    }
}
