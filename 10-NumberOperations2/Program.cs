using System;

namespace _10_NumberOperations2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input X
            Console.WriteLine("Please enter a number for X:");
            float x = float.Parse(Console.ReadLine());

            // Input Y
            Console.WriteLine("Please enter a number for Y:");
            float y = float.Parse(Console.ReadLine());

            // 1. Ask the user which mathematical operation they would like to do


            // 2. Store the choice in a string variable


            // 3. Use selection (if...else if...else) to print the correct operation


            // Wait for any key before exiting
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Questions()
        {
            // 1. What is the difference between Console.ReadLine()? and Console.ReadKey()?
            // 
            // 
            // 2. Why do we store the choice as a string?
            // 
            // 
        }

        static void ExampleOutput()
        {
            // This is an example of the program's output:
            // 
            // Please enter a number for X:
            // 7
            // Please enter a number for Y:
            // 3
            // 
            // What would you like to do:
            // 1. Addition
            // 2. Subtraction
            // 3. Multiplication
            // 4. Division
            // 
            // 1
            // 
            // The answer is: 10
            // 
            // "Press any key to continue...
        }

        static void Pseudocode()
        {
            /* 
                BEGIN
                    PRINT "Please enter a number for X:"
                    INPUT x
                    PRINT "Please enter a number for Y:"
                    INPUT y

                    PRINT "What would you like to do:"
                    PRINT "1. Addition"
                    PRINT "2. Subtraction"
                    PRINT "3. Multiplication"
                    PRINT "4. Division"
                    INPUT choice

                    IF choice = 1 THEN
                        PRINT "The answer is: " x + y
                    ELSE IF choice = 2 THEN
                        PRINT "The answer is: " x - y
                    ELSE IF choice = 3 THEN
                        PRINT "The answer is: " x * y
                    ELSE IF choice = 4 THEN
                        PRINT "The answer is: " x / y
                    ELSE
                        PRINT "Invalid choice"
                    END IF                    
                END             
             */
        }

        static void Links()
        {
            // https://www.tutorialspoint.com/csharp/csharp_operators.htm
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/operators
        }
    }
}
