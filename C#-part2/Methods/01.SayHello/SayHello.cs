//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;

class SayHello
{
    static void Main()
    {
        hello();
    }

    static void hello()
    {
        Console.Write("Please enter your name: ");
        Console.WriteLine("Hello, {0}!", Console.ReadLine());
    }
}

