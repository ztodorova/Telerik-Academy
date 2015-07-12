//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter a number less than 100:");
        int number = int.Parse(Console.ReadLine());
        int count = 0;

        if (number == 1 || number <= 0) 
            Console.WriteLine("Number is prime: false");
        else
        {
            for (int i = 2; i < number ; i++)
            {
                if (number % i == 0)
                {
                    count += 1;
                }
            }

            if (count != 0) Console.WriteLine("Number is prime: false");
            else Console.WriteLine("Number is prime: true");
        }
    }
}

