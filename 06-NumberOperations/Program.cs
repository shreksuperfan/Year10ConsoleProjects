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
            Console.WriteLine("please enter a number for y");
            float y= float.Parse(Console.ReadLine());  


            // We can then perform some mathematical operations on it. E.g. addition with +
            
            Console.WriteLine("X plus Y = " + (x + y));

            // 2. Try doing multiplication with * 
            Console.WriteLine("x times y = " + (x * y));


            // 3. Subtraction with - 
            Console.WriteLine("x take y = " + (x - y));


            // 4. Division with /
            Console.WriteLine("x divided by y = " + (x / y));


            // 5. Wait for input before ending

            Console.ReadLine();

        }
    }
}

/* ------------------------------------------------------------------------------------------ /

EXTENSION TASKS:

1. Modify the program to work with the 'double' type
2. Use Google to work out how to get the remainder of a division using the 'modulus operator'
3. Find out what happens if you use integers when dividing


QUESTIONS:
        
1. What does "float.Parse" do?
converts a string to a float


2. What is a parameter? Give an example of where you have used one.
the information used as input by a function


3. Why is the 'Console.ReadLine()' a parameter to float.Parse?
because it supplies information to float.parse



EXAMPLE:

This is what the final program output might look like:

  Please enter a number for X:
  7
  Please enter a number for Y:
  3
  X plus Y = 10
  X times Y = 21
  X minus Y = 4
  X divided by Y = 2.333333


WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers
   
/ ------------------------------------------------------------------------------------------ */