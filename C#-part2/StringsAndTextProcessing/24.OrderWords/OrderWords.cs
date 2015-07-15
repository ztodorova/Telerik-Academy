//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.OrderWords
{
    class OrderWords
    {
        static void Main()
        {
            Console.WriteLine("Please enter words separated by space: ");
            string[] input = Console.ReadLine().Split(' ');
            Array.Sort(input);
            Console.Write("Sorted words: ");
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
