using System;

namespace _15_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input two numbers
            Console.Write("Enter number 1: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int y = int.Parse(Console.ReadLine());

            // EXAMPLE: Use the function "AddNumbers" and print the result
            int additionResult = AddNumbers(x, y);
            Console.WriteLine($"{x} plus {y} equals {additionResult}");

            int additionResult2 = AddNumbers(3, 7);
            Console.WriteLine($"3 plus 7 equals {additionResult2}");
           int multiplicationresults = multiplynumbers(x, y);
            Console.WriteLine($"{x} multiplied by {y} equals {multiplicationresults}");
            int multiplicationresults2 = multiplynumbers(7, 5);
            Console.WriteLine($"{7} multiplied by {5} equals {multiplicationresults2}");

            


            // The "Wait" subroutine is called here
            Wait();
        }
        static int multiplynumbers(int num1, int num2)
        {
           return num1 * num2;
        }
        // This functions takes two numbers, adds them and returns the answer
        private static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        private static void Wait()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Questions()
        {
            // 1. What is a function?
            // 
            // 
            // 2. What does a function do that a subroutine does not?
            // return input
            // 
        }

        static void ExtensionTasks()
        {
            // 1. Try creating extra functions with parameters that do whatever you like
            // 2. Experiment with different data types for the parameters and return types
            // 3. Are there any further ways to abstract away the details of this program (e.g. InputAndAddTwoNumbers)?
        }

        static void Links()
        {
            // https://www.tutorialspoint.com/csharp/csharp_methods.htm
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
        }
    }
}
