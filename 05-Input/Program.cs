﻿using System;

namespace _05_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ask for the user's name
            Console.WriteLine("what's your name");


            // 2. Assign the result to a variable
            string name = Console.ReadLine(); 


            // 3. Output a message containing the user's name. e.g. "Hello John!"
            Console.WriteLine($"hello {name}");


            // 4. Wait for input before closing the program
            Console.ReadLine();


        }
    }
}

/* ------------------------------------------------------------------------------------------ /

EXTENSION TASKS:

1. Ask for multiple inputs
2. Use Google to work out how to input a type other than string


QUESTIONS:
        
1. What does assignment mean?
to assign a value to a variable



2. What does Console.ReadLine() do?
it waits for input and stores that input



EXAMPLE:

This is an example of creating a string variable and assigning to it with user input

  string example = Console.ReadLine();


WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers
   
/ ------------------------------------------------------------------------------------------ */