using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.MyClasses
{
    public class Fighter : Machine, IFighter
    {
        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defencePoints, bool stealthMode)
          : base(name, 200, attackPoints, defencePoints)
        {
            this.StealthMode = stealthMode;
            
        }
    

        public bool StealthMode
        {
            get { return this.stealthMode; }
            set { this.stealthMode = value; }
        }

        public void ToggleStealthMode()
        {
            bool buff = this.StealthMode;
            this.StealthMode = !buff;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("- {0}", this.Name);
            builder.AppendLine();
            builder.AppendFormat(" *Type: Fighter");
            builder.AppendLine();
            builder.AppendFormat(" *Health: {0}", this.HealthPoints);
            builder.AppendLine();
            builder.AppendFormat(" *Attack: {0}", this.AttackPoints);
            builder.AppendLine();
            builder.AppendFormat(" *Defense: {0}", this.DefensePoints);
            builder.AppendLine();
            builder.AppendFormat(" *Targets: ");
            if (this.Targets.Count <= 0)
            {
                builder.Append("None");
            }
            else
            {
                for (int i = 0; i < this.Targets.Count; i++)
                {
                    if (i == this.Targets.Count - 1)
                    {
                        builder.Append(this.Targets[i]);
                    }
                    else
                    {
                        builder.AppendFormat("{0}, ", this.Targets[i]);
                    }
                }
            }
            builder.AppendLine();
            builder.AppendFormat(" *Stealth: ");
            if (this.StealthMode)
            {
                builder.AppendLine("ON");
            }
            else
            {
                builder.AppendLine("OFF");
            }

            return builder.ToString().Trim();
        }
    }
}
