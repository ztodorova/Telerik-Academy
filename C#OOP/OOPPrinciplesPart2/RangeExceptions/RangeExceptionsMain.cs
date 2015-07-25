/*Problem 3. Range Exceptions

Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
 */ 

namespace RangeExceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class RangeExceptionsMain
    {
      public  static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                throw new InvalidRangeException<int>("Number must be in range [1..100]", 1, 100);
            }
            DateTime now = DateTime.Now;

          DateTime startDate = new DateTime(1980,1,1);

          DateTime endDate = new DateTime(2013,12,31);


          if (now.CompareTo(startDate) < 0 || now.CompareTo(endDate) > 0)
            {
                throw new InvalidRangeException<DateTime>("Number must be in range  1.1.1980 - 31.12.2013", startDate, endDate);
                
            }
          
        }
    }
}
