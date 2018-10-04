using System;

namespace _12_BetterAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu
            Console.Clear();
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1. Area of Circle");
            Console.WriteLine("2. Area of Rectangle");
            Console.WriteLine("3. Area of Triangle");
            string choice = Console.ReadLine();

            // The code is starting to get longer and more difficult to read
            // Here we are going to learn how to 'refactor code' into chunks
            // I have already extracted the code for circles into its own subroutine

            if (choice == "1")
            {                
                CalculateCircle();
            }
            else if (choice == "2")
            {
                // TASK 1:
                // Highlight the code for calculating the rectangle
                // Right click and then choose "Quick actions and Refactorings"
                // Then choose "Extract Method"
                // Give it the name: "CalculateRectangle" (no spaces allowed)
                Console.WriteLine();
                Console.Write("Width: ");
                float width = float.Parse(Console.ReadLine());
                Console.Write("Length: ");
                float length = float.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + (width * length));
            }
            else if (choice == "3")
            {
                // TASK 2:
                // I have already created a subroutine below called "CalculateTriangle"
                // Instead of using the quick actions as above, try cutting and pasting the code below into it
                // You will then have to write "CalculateTriangle();" here to 'call' it
                Console.WriteLine();
                Console.Write("Base: ");
                float width = float.Parse(Console.ReadLine());
                Console.Write("Height: ");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + (0.5 * width * height));
            }

            // Wait
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void CalculateCircle()
        {
            Console.WriteLine();
            Console.Write("Radius: ");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (Math.PI * radius * radius));
        }

        private static void CalculateTriangle()
        {

        }
    }
}
