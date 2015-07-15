//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class HexadecimalToDecimal
    {
        static void Main()
        {

            Console.Write("Please enter a hexadecimal integer: ");
            string input = Console.ReadLine();
            long decNumber = 0;
            long pow = 1;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int num;
                switch (input[i])
                {
                    case 'A': num = 10;
                        break;
                    case 'B': num = 11;
                        break;
                    case 'C': num = 12;
                        break;
                    case 'D': num = 13;
                        break;
                    case 'E': num = 14;
                        break;
                    case 'F': num = 15;
                        break;
                    default: num = (int)input[i] - 48;
                        break;
                }
                decNumber += num * pow;
                pow *= 16;
            }
            Console.WriteLine("Decimal representation: {0}",decNumber);
        }

        }
    

