using System;

namespace _23_NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Run the program and see how this example works
            // When you are done comment it out and do task 2
            SquaresAndCubes(2,10);

            // 2. Create a nested FOR loops structure that prints out the 12 times tables
            //  - Don't forget to use different variables (e.g. i and j) for the counters
            //  - Try to format it nicely using a combination of 'Write' and 'WriteLine'


            // Wait at end
            WaitForKeyPress();
        }

        // Below is a silly example of how to calculate squares and cubes of a range of numbers
        // It does illustrate that you can 'nest' loops within each other
        static void SquaresAndCubes(int min, int max)
        {
            for (int i = min; i <= max; i++) // Outer loop
            {
                for (int j = min; j <= max; j++) // Middle Loop
                {
                    if(i == j)
                    {
                        Console.WriteLine($"{i} squared equals {i * j}"); // Squared
                    }

                    for (int k = min; k <= max; k++) // Inner Loop
                    {
                        if(i == j && j == k)
                        {
                            Console.WriteLine($"{i} cubed equals {i * j * k}"); // Cubed
                        }
                    }
                }
                Console.WriteLine("-------------------"); // Seperator
            }
            Console.ReadKey();
        }

        private static void WaitForKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
