using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Please enter a binary integer: ");
        string binary = Console.ReadLine();
        long result = 0;
        for (int i = 0, j = binary.Length - 1; i <= binary.Length && j >= 0; i++, j--)
        {
            int bin = binary[i] - '0';
            result += ((long)bin * (long)Math.Pow(2, j));
        }

        Console.WriteLine("Decimal representation: {0}", result);
    }

}


