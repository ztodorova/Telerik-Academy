/*
 * Problem 1. School classes

We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches, a set of disciplines. Students have a name and unique class number. Classes have unique text identifier. Teachers have a name. Disciplines have a name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
 */
namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SchoolClassesMain
    {
        static void Main()
        {
            Student pesho = new Student("Pesho", 8);
            Student gosho = new Student("Gosho", 8, "kaval");
            Teacher stamatov = new Teacher("Stamatov", "bastun");
            Teacher petrova = new Teacher("Petrova");

            Class myClass = new Class("A");
            myClass.AddStudent(pesho);
            myClass.AddStudent(gosho);
            myClass.AddTeacher(stamatov);
            myClass.AddTeacher(petrova);

            Discipline biologia = new Discipline("biologia", 30, 30);
            Discipline matematika = new Discipline("matematika", 40, 40, "cool");

            stamatov.AddDiscipline(biologia);
            petrova.AddDiscipline(matematika);

            for (int i = 0; i < myClass.Students.Count; i++)
            {
                Console.WriteLine(myClass.Students[i].Name);
            }


            Console.WriteLine();
            myClass.RemoveStudent(pesho);

            for (int i = 0; i < myClass.Students.Count; i++)
            {
                Console.WriteLine(myClass.Students[i].Name);
            }

            Console.WriteLine();

            for (int i = 0; i < myClass.Teachers.Count; i++)
            {
                Console.WriteLine(myClass.Teachers[i].Name);
            }

            myClass.RemoveTeacher(petrova);
            Console.WriteLine();

            for (int i = 0; i < myClass.Teachers.Count; i++)
            {
                Console.WriteLine(myClass.Teachers[i].Name);
            }

            stamatov.AddDiscipline(matematika);
            Console.WriteLine();

            for (int i = 0; i < stamatov.Disciplines.Count; i++)
            {
                Console.WriteLine(stamatov.Disciplines[i].NameOfDiscipline);
            }
        }
    }
}
