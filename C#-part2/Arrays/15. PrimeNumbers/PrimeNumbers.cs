//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;

class PrimeNumbers
{
    static void Main()
    {
        bool[] prime = new bool[100000];  //[10000000]; The program is too slow with this number
        for (int i = 2; i < prime.Length; i++)
        {
            prime[i] = true;
        }

        for (int i = 2; i < prime.Length; i++)
        {
            if (prime[i])
            {
                for (int j = i * 2; j < prime.Length; j += i)
                {
                    prime[j] = false;
                }
            }
        }

        for (int i = 1; i < prime.Length; i++)
        {
            if (prime[i])
                Console.WriteLine(i);
        }
    }
}

