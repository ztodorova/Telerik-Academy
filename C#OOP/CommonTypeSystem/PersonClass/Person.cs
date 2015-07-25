using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonClass
{
   public class Person
    {
        public string Name { get; private set; }
        public int? Age { get; private set; }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
               StringBuilder builder = new StringBuilder();
            builder.Append("Name: ");
            builder.AppendLine(this.Name);

            if (this.Age==null)
            {
                builder.AppendLine("Age is not specified!");
            }
            else
            {
                builder.Append("Age: ");
                builder.AppendLine(this.Age.ToString());
            }
            return builder.ToString();

        }
    }
}
