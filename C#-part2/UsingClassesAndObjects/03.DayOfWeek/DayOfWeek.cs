//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

class DayOfWeek
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        DateTime today = DateTime.Now;  
        Console.WriteLine("Today is {0:dddd}.", today);
    }
}

