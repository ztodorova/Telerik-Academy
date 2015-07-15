//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Random number = new Random();
        Console.WriteLine("Random numbers in the range [100,200]: ");
        for (int i = 1; i <=10 ; i++)
        {
            Console.WriteLine(number.Next(100,201));
        }

    }
}

