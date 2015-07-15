/* Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CorrectBrakets
{
    class CorrectBrakets
    {
        static void Main()
        {
            Console.Write("Please write an experession: ");
            string input = Console.ReadLine();
            int counter=0;
            foreach (char symbol in input)
            {
                switch(symbol)
                {
                    case '(': counter++;
                        break;
                    case ')': counter--;
                        break;
                    default: break;
                }
                if(counter<0)
                {
                    break;
                }

            }

            if (counter == 0)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
            
        }
    }
}
