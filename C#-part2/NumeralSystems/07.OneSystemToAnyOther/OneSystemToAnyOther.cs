﻿//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;

namespace OneSystemToAnyOther
{
    class OneSystemToAnyOther
    {
        static string ConvertNumbericSystem(string value, int base1, int base2)
        {
            ulong decRepresentation = 0;

            // base 1 to decimal system
            for (int i = value.Length - 1; i >= 0; i--)
            {
                if (Char.IsDigit(value[i]))
                {
                    decRepresentation += (ulong)((value[i] - '0') * Math.Pow(base1, value.Length - i - 1));
                }
                else
                {
                    int num = 0;

                    switch (value[i])
                    {
                        case 'a':
                        case 'A':
                            num = 10;
                            break;
                        case 'b':
                        case 'B':
                            num = 11;
                            break;
                        case 'c':
                        case 'C':
                            num = 12;
                            break;
                        case 'd':
                        case 'D':
                            num = 13;
                            break;
                        case 'e':
                        case 'E':
                            num = 14;
                            break;
                        case 'f':
                        case 'F':
                            num = 15;
                            break;
                        default:
                            break;
                    }

                    decRepresentation += (ulong)(num * Math.Pow(base1, value.Length - i - 1));
                }
            }

            ulong remainder;
            string result = string.Empty;

            while (decRepresentation > 0)
            {
                remainder = (ulong)(decRepresentation % (ulong)base2);
                decRepresentation /= (ulong)base2;

                if (remainder < 10)
                {
                    result = remainder.ToString() + result;
                }
                else
                {
                    switch (remainder)
                    {
                        case 10:
                            result = "A" + result;
                            break;
                        case 11:
                            result = "B" + result;
                            break;
                        case 12:
                            result = "C" + result;
                            break;
                        case 13:
                            result = "D" + result;
                            break;
                        case 14:
                            result = "E" + result;
                            break;
                        case 15:
                            result = "F" + result;
                            break;
                        default:
                            break;
                    }
                }
            }
            return result;
        }

        static void Main()
        {
            Console.Write("S = ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("D = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Value = ");
            string value = Console.ReadLine();

            if ((s < 2) || (d > 16))
            {
                Console.WriteLine("Invalid value entered!");
            }
            else
            {
                Console.WriteLine("Value {0} in {1} system = Value {2} in {3} system.", value, s, ConvertNumbericSystem(value, s, d), d);
            }
        }
    }
}
