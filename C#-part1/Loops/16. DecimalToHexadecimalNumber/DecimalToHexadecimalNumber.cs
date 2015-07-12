//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Please enter integer number: ");
        long n = long.Parse(Console.ReadLine());
        long result = n;
        string hex = "";
        if (n == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            while (result > 0)
            {

                long current = result % 16;
                switch (current)
                {
                    case 10:
                        hex += 'A';
                        break;
                    case 11:
                        hex += 'B';
                        break;
                    case 12:
                        hex += 'C';
                        break;
                    case 13:
                        hex += 'D';
                        break;
                    case 14:
                        hex += 'E';
                        break;
                    case 15:
                        hex += 'F';
                        break;
                    default:
                        hex += current.ToString();
                        break;
                }
                result /= 16;
            }

            char[] hexArray = hex.ToCharArray();
            for (int i = hexArray.Length - 1; i >= 0; i--)
            {
                Console.Write(hexArray[i]);
            }
            Console.WriteLine();
        }
    }
}

