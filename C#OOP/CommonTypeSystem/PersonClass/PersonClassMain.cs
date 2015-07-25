using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonClass
{
   public class Program
    {
        static void Main()
        {
            Person pesho = new Person("Pesho"); //new Person("Pesho",5);

            Console.WriteLine(pesho.Age);

            Console.WriteLine("Pesho info:");
            Console.WriteLine();
            Console.WriteLine(pesho.ToString());
        }
    }
}
