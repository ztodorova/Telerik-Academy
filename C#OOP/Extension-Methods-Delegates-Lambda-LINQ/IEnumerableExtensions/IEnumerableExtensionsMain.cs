//Problem 2. IEnumerable extensions

//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    class IEnumerableExtensionsMain
    {
        static void Main()
        {
            List<double> list = new List<double>();
            list.Add(2);
            list.Add(1);
            list.Add(4);
            Console.WriteLine(list.Min());
        }
    }
}
