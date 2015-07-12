/*A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times. */

using System;
using System.Globalization;
using System.Threading;

    class BeerTime
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write(@"Please enter a time in format “hh:mm tt”: ");
            string s = Console.ReadLine();
            string format = "h:mm tt";
            string from ="01:00 PM";
            string until = "02:59 AM";
            

            DateTime inputTime = DateTime.ParseExact(s, format, CultureInfo.InvariantCulture);
            DateTime fromTime = DateTime.Parse(from);
            DateTime untilTime = DateTime.Parse(until);

            if ((inputTime <= untilTime) || (inputTime >= fromTime))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }

