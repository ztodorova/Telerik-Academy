using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.MyClasses
{
    public abstract class Machine : IMachine 
    {
        private string name;
        private IPilot pilot;
        private double healthpoints;
        private double attackpoints;
        private double defencepoints;
        public IList<string> targets;

        public Machine(string name, double healthPoints, double attackPoints, double defencePoints )
        {
            this.Name = name;
            //this.Pilot = pilot;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defencePoints;
            this.Targets = new List<string>();
        }


        public string Name
        {
            get
            {
                return this.name;
            }
           set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                
                 this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthpoints;
            }
            set
            {
                this.healthpoints = value;

            }
        }

        public double AttackPoints
        {
            get { return this.attackpoints; }
            protected set
            {
                this.attackpoints = value;
            }
        }

        public double DefensePoints
        {
            get { return this.defencepoints; }
            protected set
            {
                this.defencepoints = value;
            }
        }

        public IList<string> Targets
        {
            get { return this.targets; }
            private set 
            {
                this.targets = value;
            }
            
        }

        public void Attack(string target)
        {
            this.Targets.Add(target);
        }

        
    }
}
