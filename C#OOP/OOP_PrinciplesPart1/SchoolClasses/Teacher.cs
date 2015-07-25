using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolClasses
{
    public class Teacher : Person
    {
        private List<Discipline> discipline;

        public Teacher(string name) : base(name)
        {
            this.Disciplines = new List<Discipline>();
        }

        public Teacher(string name, string comment) : base(name,comment)
        {
            this.Disciplines = new List<Discipline>();
        }

        public List<Discipline>Disciplines
        {
            get
            {
               return this.discipline;
            }
            set
            {
                this.discipline = value;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
        this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }
    }
}
