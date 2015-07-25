// Problem 6. Divisible by 7 and 3

//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace DivisibleBy7and3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    
    class Program
    {
        static void Main()
        {
            int[] integers = { 2, 3, 7, 5, 23, 33, 21, 9, 14 };
            //Lambda Ex
            var divisible = integers.Where(x => x % 3 == 0 && x % 7 == 0);
            Console.Write("Integers divisible by 3 and 7 (lambda): ");

            foreach (var integer in divisible)
            {
                Console.Write("{0} ", integer);
            }
            Console.WriteLine();

            //LINQ
            
            var div =
                from integer in integers
                where (integer % 3 == 0) && (integer % 7 == 0)
                select integer;

            Console.Write("Integers divisible by 3 and 7 (linq): ");
            foreach (var integer in div)
            {
                Console.Write("{0} ",integer );
            }
            Console.WriteLine();
        }
    }
}
