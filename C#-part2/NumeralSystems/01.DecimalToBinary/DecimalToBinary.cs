//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number = ");
            long n = long.Parse(Console.ReadLine());
            string counter = "";

            while (n >= 1)
            {
                counter = (n % 2) + counter;
                n = n / 2;
            }

            Console.WriteLine("Binary: " + counter);
        }
    }
}



