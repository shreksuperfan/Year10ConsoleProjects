using System;

namespace _06_NumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is how we can store user input as a floating point number
            Console.WriteLine("Please enter a number for X:");
            float x = float.Parse(Console.ReadLine());

            // 1. Now do the same for the variable 'y'


            // We can then perform some mathematical operations on it. E.g. addition
            Console.WriteLine("X plus Y = " + (x + y));

            // 2. Try doing multiplication, subtraction and division below


            // 3. Wait for input before ending


        }

        static void ExtensionTasks()
        {
            // 1. Modify the program to work with the 'double' type
            // 2. Use Google to work out how to get the remainder of a divison using the 'modulus operator'
        }

        static void Questions()
        {
            // 1. What does "float.Parse" do?
            // 
        }

        static void Example()
        {
            // These are the different operators:
            //       Addition:  +
            //    Subtraction:  -
            // Multiplication:  *
            //       Division:  /
        }

        static void Example2()
        {
            // This is what the final program output might look like:
            //
            // Please enter a number for X:
            // 7
            // Please enter a number for Y:
            // 3
            // X plus Y = 10
            // X times Y = 21
            // X minus Y = 4
            // X divided by Y = 2.333333
         }
    }
}
