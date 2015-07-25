using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolClasses
{
    public class Person : School
    {
        private string name;
    
        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, string comment) : base(comment)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }


        }
    }
}
