﻿//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace _11.FormatNumber
{
    class FormatNumber
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Decimal number: {0,15:D}",number);
            Console.WriteLine("Hexadecimal numer: {0,15:X}",number);
            Console.WriteLine("Percentage: {0,15:P}", number);
            Console.WriteLine("Scientific notation:{0,15:E}",number); 

        }
    }
}
