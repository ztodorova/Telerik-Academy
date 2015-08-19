using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.MyClasses
{
    public class Tank : Machine, ITank
    {
        private bool defenseMode;

        public Tank(string name, double attackPoints, double defencePoints)
            : base(name, 100,attackPoints,defencePoints)
        {
            ToggleDefenseMode();
            
        }


        public bool DefenseMode
        {
            get {return  this.defenseMode; }
            set
            {
                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {


            if (this.DefenseMode)
            {
                this.defenseMode = false;
            }
            else
            {
                this.DefenseMode = true;
                this.DefensePoints += 30;
                this.AttackPoints -= 40;     
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("- {0}", this.Name);
            builder.AppendLine();
            builder.AppendFormat(" *Type: Tank");
            builder.AppendLine();
            builder.AppendFormat(" *Health: {0}", this.HealthPoints);
            builder.AppendLine();
            builder.AppendFormat(" *Attack: {0}", this.AttackPoints);
            builder.AppendLine();
            builder.AppendFormat(" *Defense: {0}",this.DefensePoints);
            builder.AppendLine();
            builder.AppendFormat(" *Targets: ");
            if(this.Targets.Count <= 0)
            {
                builder.Append("None");
            }
            else{
                for (int i = 0; i < this.Targets.Count; i++)
			{
                    if(i==this.Targets.Count-1)
                    {
                    builder.Append(this.Targets[i]);
                    }
                    else{
			 builder.AppendFormat("{0}, ",this.Targets[i]); 
                        }
			}
            }
            builder.AppendLine();
            builder.AppendFormat(" *Defense: ");
            if(this.DefenseMode)
            {
                builder.AppendLine("ON");
            }
            else{
                builder.AppendLine("OFF");
            }

            return builder.ToString().Trim();
        }

        /*
         * - (machine name)
 *Type: (“Tank”/”Fighter”)
 *Health: (machine health points)
 *Attack: (machine attack points)
 *Defense: (machine defense points)
 *Targets: (machine target names/”None” – comma separated)
 *Defense: (“ON”/”OFF” – when applicable)
 *Stealth: (“ON”/”OFF” – when applicable)

         */
    }
}
