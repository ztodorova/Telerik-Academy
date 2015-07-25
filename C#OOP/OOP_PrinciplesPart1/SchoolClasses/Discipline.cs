using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolClasses
{
    public class Discipline : School
    {
        private string nameOfDiscipline;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string nameOfDiscipline, int numberOfLectures, int numberOfExercises): base()
        {
            this.NameOfDiscipline = nameOfDiscipline;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public Discipline(string nameOfDiscipline, int numberOfLectures, int numberOfExercises, string comment)
            : base(comment)
        {
            this.NameOfDiscipline = nameOfDiscipline;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string NameOfDiscipline
        {
            get
            {
                return this.nameOfDiscipline; 
            }
            private set
            {
                this.nameOfDiscipline = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
           private set
            {
                this.numberOfLectures = value;
            }
        }

        private int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                this.numberOfExercises = value;
            }
        }
    }
}
