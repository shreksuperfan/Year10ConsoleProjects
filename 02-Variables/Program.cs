using System;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a string variable and assign it a value
            string firstname = "tom ";
            string lastname = "sullivan";

            // 2. Output a message that contains this variable
            Console.WriteLine($"hello my name is {firstname} {lastname}");

            // 3. Make the program wait for input
            Console.WriteLine("my name is "+firstname); 


            Console.ReadLine();     

        }
    }
}


/* ------------------------------------------------------------------------------------------ /

EXTENSION TASKS:

1. Try creating two string variables and using them in the same message
2. Use Google to work out how to change a variable to uppercase or lowercase before outputting it


QUESTIONS:
        
1. What is a variable?



2. What is a string?



EXAMPLE:

This is an example of creating a string variable and joining it to an output message

  string example = "hello to you";
  Console.WriteLine("My message is: " + example);
  Console.ReadLine();


LINKS:

https://www.tutorialspoint.com/csharp/csharp_variables.htm
https://www.tutorialspoint.com/csharp/csharp_data_types.htm


WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers
   
/ ------------------------------------------------------------------------------------------ */