﻿//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Please enter a hexadecimal integer: ");
        string input = Console.ReadLine();
        long decNumber = 0;
        long pow = 1;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            int num;
            switch (input[i])
            {
                case 'A': num = 10;
                    break;
                case 'B': num = 11; 
                    break;
                case 'C': num = 12; 
                    break;
                case 'D': num = 13; 
                    break;
                case 'E': num = 14; 
                    break;
                case 'F': num = 15; 
                    break;
                default: num = (int)input[i] - 48; 
                    break;
            }
            decNumber += num * pow;
            pow *= 16;
        }
        Console.WriteLine(decNumber);
    }
}

