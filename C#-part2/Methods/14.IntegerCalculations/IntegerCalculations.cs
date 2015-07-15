//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;

class IntegerCalculations
{
    static void Main()
    {
        Console.Write("Please enter number of arguments: ");
        int n = int.Parse(Console.ReadLine());
        int[] integers = new int[n];
        Console.Write("Please enter {0} numbers separeted by space: ",n);
        string[] input = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            integers[i] = int.Parse(input[i]);
        }

        Console.WriteLine("Minimum: {0}",Minimum(integers));
        Console.WriteLine("Maximum: {0}", Maximum(integers));
        Console.WriteLine("Average:{0}",Average(integers));
        Console.WriteLine("Sum: {0}",Sum(integers));
        Console.WriteLine("Product: {0}",Product(integers));
    }

    static int Minimum(int[] numbers)
    {
        int min = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
           if(numbers[i]<min)
           {
               min = numbers[i];
           }
        }
        return min;
    }

    static int Maximum(int[] numbers)
    {
        int max = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
			{
			 if(numbers[i]>max)
             {
                 max = numbers[i];
             }
			}
            return max;
    }

    static double Average(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        double avg =(double)sum / (double)numbers.Length;
        return avg ;
    }

    static int Sum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    static int Product(int[] numbers)
    {
        int prod = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            prod *= numbers[i];
        }
        return prod;
    }
}
