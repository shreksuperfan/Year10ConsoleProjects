using System;

namespace _13_Subroutines
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a subroutine called "SayHello" to print the message "Hello World"


            // The "Wait" subroutine is called here
            Wait();

        }

        private static void Wait()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Questions()
        {
            // 1. What is a subroutine?
            // 
            // 
            // 2. What does the 'void' keyword mean?
            // 
            // 
            // 3. What does it mean to 'call' a subroutine?
            // 
            //
        }

        static void ExtensionTasks()
        {
            // 1. Try creating extra subroutines that do whatever you like
            // 2. Try calling the subroutines multiple times
            // 3. Try calling a subroutine from within another
        }
    }
}
