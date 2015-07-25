using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class Call
    {
        private string dialledNumber;
        private int duration;

        public DateTime Date { get; set; }

        public string DialledNumber
        {
            get { return this.dialledNumber; }
            set
            {
                if (value.Length < 10)
                {
                    throw new FormatException("Invalid phone number!");
                }
                this.dialledNumber = value;
            }
        }

        public int Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("Duration must be positive integer!");
                }
                this.duration = value;
            }
        }


        public Call(DateTime date, string dialledNumber, int duration)
        {
            this.Date = date;
            this.DialledNumber = dialledNumber;
            this.Duration = duration;
        }
    }
}
