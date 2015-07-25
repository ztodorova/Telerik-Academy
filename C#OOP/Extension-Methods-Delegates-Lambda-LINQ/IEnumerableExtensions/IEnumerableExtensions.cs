using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    public static class IEnumerableExtensions 
    {
        public static decimal Sum<T>(this IEnumerable<T> number) 
        {
            decimal sum = 0;
            foreach (var item in number)
            {
                sum += Convert.ToDecimal(item);
            }
            return sum;
        }
        public static decimal Product<T>(this IEnumerable<T> number)
        {
            decimal product = 1;
            foreach (var item in number)
            {
                product *= Convert.ToDecimal(item);
            }
            return product;
        }
        public static T Min<T>(this IEnumerable<T> numbers) where T : IComparable
        {
            T min = numbers.First();
            foreach (var item in numbers)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min; 
        }
        public static T Max<T>(this IEnumerable<T> numbers) where T : IComparable
        {
            T max = default(T);
            foreach (var item in numbers)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }
        public static  decimal Average<T>(this IEnumerable<T> numbers)
        {
            decimal result = 0;
           result=numbers.Sum() / numbers.Count();
           return result;
        }
    }
}
