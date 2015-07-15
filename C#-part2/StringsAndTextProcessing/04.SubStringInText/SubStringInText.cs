/*Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SubStringInText
{
    class SubStringInText
    {
        static void Main()
        {
            Console.WriteLine("Please enter some text: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please enter a string to search: ");
            string sub = Console.ReadLine();
            int counter = 0; 
            int index = input.IndexOf(sub);
            while(index >= 0)
            {
                counter++;
                index = input.IndexOf(sub, index+1);
            }
            Console.WriteLine();
            Console.WriteLine("{0} times", counter);
            Console.WriteLine();
        }
    }
}
