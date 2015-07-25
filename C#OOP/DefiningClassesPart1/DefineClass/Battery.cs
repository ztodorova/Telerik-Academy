

namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Battery
    {
        private double hoursIdle;
        private double hoursTalk;

        public string BatteryModel { get; private set; }
        public BatteryType BatteryType { get; set; }

        public double HoursIdle {
            get { return this.hoursIdle; }
            set{
                if (value<0)
                {
                    throw new FormatException("HoursIdle must be a positive integer!");
                }
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("HoursIdle must be a positive integer!");
                }
                this.hoursTalk = value;
            }
        } 

        public Battery(string batteryModel)
        {
        this.BatteryModel = batteryModel;
        }

        public Battery (string batteryModel, double hoursIdle, double hoursTalk, BatteryType batteryType) : this(batteryModel)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }
    }
}
    