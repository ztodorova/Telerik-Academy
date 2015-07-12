//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
using System.Threading;
using System.Globalization;

    class PlayWithIntDoubleString
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please choosea type:\n1 --> int\n2 --> double\n3 --> string");
            switch(Console.ReadLine())
            {
                case "1": 
                    Console.Write("Please enter an int: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine(n+1);
                    break;
                case "2": 
                    Console.Write("Please enter a double: ");
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine(d+1.0);
                    break;
                case "3": 
                    Console.Write("Please enter a string: ");
                    Console.WriteLine(Console.ReadLine()+"*");
                    break;
                default: Console.WriteLine("Invalid choice");
                            break;
            }
        }
    }

