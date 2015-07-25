

namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class GSM
    {
        private decimal price;

        private static GSM iPhone4S = new GSM("IPhone", "Apple", 300.00M, "Pesho", new Battery("ModelBateria"), new Display());
        public string Model { get; private set; }
        public string Manufacturer { get; private set; }

        public string OwnerName { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        public List<Call> CallHistory { get; set; }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }

            private set
            {
                iPhone4S = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("Preice of the phone must be positive integer!");
                }
                this.price = value;
            }
        }


        public GSM(string phoneModel, string phoneManufacturer)
        {
            this.Model = phoneModel;
            this.Manufacturer = phoneManufacturer;
            this.Battery = new Battery("");
            this.Display = new Display();
            this.CallHistory = new List<Call>();
        }

        public GSM(string phoneModel, string phoneManufacturer, decimal phonePrice)
            : this(phoneModel, phoneManufacturer)
        {
            this.Price = phonePrice;

        }

        public GSM(string phoneModel, string phoneManufacturer, decimal phonePrice, string phoneOwner, Battery myBattery, Display myDisplay)
            : this(phoneModel, phoneManufacturer, phonePrice)
        {
            this.OwnerName = phoneOwner;
            this.Battery = myBattery;
            this.Display = myDisplay;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Model: ");
            result.AppendLine(this.Model);
            result.Append("Manufacturer: ");
            result.AppendLine(this.Manufacturer);
            result.Append("Price: ");
            string priceOfGSM = this.Price.ToString();
            result.AppendLine(priceOfGSM);
            result.Append("Owner name: ");
            result.AppendLine(this.OwnerName);
            result.Append("Battery model: ");
            result.AppendLine(this.Battery.BatteryModel);
            result.Append("Battery Idle: ");
            result.AppendLine(this.Battery.HoursIdle.ToString());
            result.Append("Battery Talk:");
            result.AppendLine(this.Battery.HoursTalk.ToString());
            result.Append("Display size: ");
            string displaySize = this.Display.Size.ToString();
            result.AppendLine(displaySize);
            result.Append("Number of colours of display: ");
            result.AppendLine(this.Display.NumberOfColours.ToString());

            return result.ToString();
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            int index = CallHistory.IndexOf(call);
            CallHistory.RemoveAt(index);
        }

        public void ClearCalls()
        {
            CallHistory.RemoveRange(0, CallHistory.Count);
        }

        public decimal CalculateTotalPriceOfCalls(decimal ppMinute)
        {
            decimal result = 0.0M;
            decimal duration = 0.0M;

            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                duration += (decimal)this.CallHistory[i].Duration;
            }
            result = (duration / 60) * ppMinute;
            return result;
        }

        public string CallHistoryInfo()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                builder.Append("Call Date&Time: ");
                builder.AppendLine(this.CallHistory[i].Date.ToString());
                builder.Append("Dialled number: ");
                builder.AppendLine(this.CallHistory[i].DialledNumber);
                builder.Append("Duration: ");
                builder.AppendLine(this.CallHistory[i].Duration.ToString());
            }
            return builder.ToString();
        }

    }
}
