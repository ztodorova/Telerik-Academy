﻿//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double greater = (firstNumber > secondNumber ? firstNumber : secondNumber);
            Console.WriteLine("The greater number is: {0}", greater);
          
        }
    }

