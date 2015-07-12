//Write a program that prints an isosceles triangle of 9 copyright symbols ©

using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char character = '\u00A9';
        
        Console.WriteLine("   {0}", character);
        Console.WriteLine();
        Console.WriteLine("  {0} {0}", character);
        Console.WriteLine();
        Console.WriteLine(" {0}   {0}", character);
        Console.WriteLine();
        Console.WriteLine("{0} {0} {0} {0}", character);
       
    }
}

