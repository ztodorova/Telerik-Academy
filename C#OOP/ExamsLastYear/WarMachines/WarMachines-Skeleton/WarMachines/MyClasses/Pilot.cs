using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.MyClasses
{
   public class Pilot : IPilot 
    {
       private string name;
       public List<IMachine> Machines { get; private set; }

       public Pilot(string name)
       {
           this.Name = name;
           this.Machines = new List<IMachine>();
       }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        

        public void AddMachine(IMachine machine)
        {
            this.Machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("{0} - ", this.Name);
                //("{0} – {1} machines",this.Name,this.Machines.Count);
            if (this.Machines.Count == 0)
            {
                builder.Append("no machines");
            }
            else
            {
                builder.AppendFormat("{0} ", this.Machines.Count);
                if (this.Machines.Count == 1)
                {
                    builder.AppendLine("machine");
                }
                else
                {
                    builder.AppendLine("machines");
                }
            }

            var sortedList = this.Machines.OrderBy(x => x.HealthPoints).ThenBy(x => x.Name);



            foreach (var machine in sortedList)
            {
                builder.AppendLine(machine.ToString());
            }

            return builder.ToString().Trim();

        }
    }
}
