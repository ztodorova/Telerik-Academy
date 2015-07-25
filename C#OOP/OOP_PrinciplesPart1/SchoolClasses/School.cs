using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolClasses
{
    public class School
    {
        private string comment;

        public School()
        {

        }
    
        public School (string comment)
        {
            this.comment = comment;
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
    }
}
