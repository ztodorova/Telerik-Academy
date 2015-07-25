using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _64BitArray
{
   public class BitArray64Main
    {
        public static void Main()
        {
            BitArray64 oneValue = new BitArray64(10u);
            BitArray64 secondValue = new BitArray64(10u);
            BitArray64 thirdValue = new BitArray64(20u);

            Console.WriteLine("oneValue equals secondValue: {0}",oneValue.Equals(secondValue));
            Console.WriteLine("oneValue equals thirdValue: {0}", oneValue.Equals(thirdValue));
            Console.WriteLine();
            Console.WriteLine("oneValue == secondValue: {0}", oneValue==secondValue);
            Console.WriteLine("oneValue == thirdValue: {0}", oneValue == thirdValue);
            Console.WriteLine("oneValue != thirdValue: {0}", oneValue!=thirdValue);
            Console.WriteLine("oneValue == secondValue: {0}", oneValue != secondValue);
            Console.WriteLine();
            Console.WriteLine("oneValue.GetHashCode: {0}",oneValue.GetHashCode());
            Console.WriteLine();
        }
    }
}
