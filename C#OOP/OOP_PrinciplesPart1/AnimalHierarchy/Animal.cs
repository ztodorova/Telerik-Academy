

namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Sex sexOfAnimal;

        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.SexOfAnimal = sex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Please enter name!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("Invalid age!");
                }
                this.age = value;
            }
        }

        public Sex SexOfAnimal
        {
            get
            {
                return this.sexOfAnimal;
            }
            set
            {
                if((value != Sex.male)&&(value !=Sex.female))
                {
                    throw new FormatException("Ivalid sex of the animal!");
                }
                this.sexOfAnimal = value;
            }
        }

        public abstract string ProduceSound();

        public static double AverageAge(Animal[] animals)
        {

            return animals.Average(x => x.Age);
        }

    }
}
