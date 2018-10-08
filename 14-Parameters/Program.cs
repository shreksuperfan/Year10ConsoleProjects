using System;

namespace _14_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a subroutine called "SayHello" to print the message "Hello (name)"


            // The following subroutine takes two integers, adds them and prints the result.
            AddNumbers(3, 7);

            // 2. Create a subroutine called "SubtractNumbers" that takes takes two integers, subtracts one and prints the result


            // The "Wait" subroutine is called here
            Wait(ConsoleColor.Blue);
        }

        private static void AddNumbers(int num1, int num2)
        {
            int answer = num1 + num2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine($"{num1} + {num2} equals {answer}");
        }

        private static void Wait(ConsoleColor textColor)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Questions()
        {
            // 1. What is a parameter?
            // 
            // 
            // 2. What two things does a parameter need when you create a subroutine?
            // 
            // 
        }

        static void ExtensionTasks()
        {
            // 1. Try creating extra subroutines with parameters that do whatever you like
            // 2. Try calling a subroutine with a parameter from within another
            // 3. Experiment with different data types for the parameters
        }
    }
}
