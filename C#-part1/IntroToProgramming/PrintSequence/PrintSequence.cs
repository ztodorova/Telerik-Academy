﻿// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            if (i%2==0)
            {
                Console.Write(i+",");   
            }
            else
            {
                Console.Write(-i+",");
            }
            
        }
    }
}

