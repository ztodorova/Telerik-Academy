using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    class FirstBeforeLastMain
    {

        static void Main()
        {
                Student[] studentsArray = {
                                              new Student("Ivan","Ivanov", 25),
                                              new Student("Pesho","Peshev",23),
                                              new Student("Todor","Todorov",29),
                                          };
                //Problem 3. First before last
            var output = FirstNameBeforeLast(studentsArray);
            foreach (var student in output)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
            }

            //Problem 4. Age range
            IEnumerable<Student> ageRange =
                from student in studentsArray
                where student.Age >= 18 && student.Age <= 25
                select student;
            Console.WriteLine();

            Console.WriteLine("Students with age between 18 and 25:");
            foreach (var student in ageRange)
	        {
		    Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
	        }

            Console.WriteLine();

            //Problem 5. Order students
            var sortedStudents = studentsArray
                .OrderByDescending (s => s.FirstName)
                .ThenByDescending(s => s.LastName);
            Console.WriteLine("Ordered students by First name and last name in descending order (lambda ex):");
            foreach (var student in studentsArray)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }


            var sortedStudents1 =
                from student in studentsArray
                orderby student.FirstName descending, student.LastName descending
                select student;
                
            Console.WriteLine("Ordered students by First name and last name in descending order (linq):");
            foreach (var student in sortedStudents1)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine();

        }
        //Problem 3. First before last
        private static IEnumerable<Student> FirstNameBeforeLast(Student[] students)
        {
            IEnumerable<Student> result =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            return result;
        }
    }
}
