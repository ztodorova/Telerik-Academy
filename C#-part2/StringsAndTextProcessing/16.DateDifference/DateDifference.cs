/*Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DateDifference
{
    class DateDifference
    {
        static void Main()
        {
            Console.Write("Please enter date in format day.month.year: ");
            string[] firstDate = Console.ReadLine().Split('.');
            DateTime first = new DateTime(int.Parse(firstDate[2]), int.Parse(firstDate[1]), int.Parse(firstDate[0]));
            Console.Write("Please enter another date in format day.month.year: ");
            string[] secondDate = Console.ReadLine().Split('.');
            DateTime second = new DateTime(int.Parse(secondDate[2]), int.Parse(secondDate[1]), int.Parse(secondDate[0]));
            int days = second.DayOfYear - first.DayOfYear - 1;
            Console.WriteLine("Days between them: {0}", days);

        }
    }
}
