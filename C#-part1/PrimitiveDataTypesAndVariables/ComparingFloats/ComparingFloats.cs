/*Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. */

using System;

class ComparingFloats
{
    static void Main()
    {

        double oneNumber = 5.00000001;
        double anotherNumber = 5.00000003;
        bool equal;

        equal = Math.Abs(oneNumber - anotherNumber) < 0.000001;

        Console.WriteLine(equal);
    }
}

