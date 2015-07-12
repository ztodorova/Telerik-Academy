using System;

class CalculateGSD
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        while (Math.Abs(a) != Math.Abs(b))
        {
        if (Math.Abs(a) > Math.Abs(b))
        {
        a =Math.Abs(a) - Math.Abs(b);
        }
        else
        {
        b = Math.Abs(b) - Math.Abs(a);
        }
        }
        Console.WriteLine("GCD(a, b) = {0}", a);
    }
}

