
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
   public class StudentGroup
    {

       

       public static void Main()
        {
           

            Student pesho = new Student("Pesho", "Peshev", "213400","032555555","pesho@abv.bg", 1);
            Student ivan = new Student("Ivan", "Ivanov", "213406","03255555","ivan@abv.bg", 2);
            Student kina = new Student("Kina", "Kinova", "213806","029999999","kina@gmail.com", 1);
            Student pina = new Student("Pina", "Pinova", "213490","0266666","pina@gmail.com", 2);

            

            pesho.Marks.Add(2);
            pesho.Marks.Add(2);
            ivan.Marks.Add(6);
            kina.Marks.Add(6);
            
            List<Student> students= new List<Student>();
            students.Add(pesho);
            students.Add(ivan);
            students.Add(kina);
            students.Add(pina);


            //Problem 9. Student groups

            Console.WriteLine();
            Console.WriteLine("Students from group 2 (Linq) ");
            var studentGroup = 
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var student in studentGroup)
            {
                Console.WriteLine(student.FirstName);
            }
            
            Console.WriteLine("Students from group 2 (Extension m): ");

           //Problem 10. Student groups extensions
           //Implement the previous using the same query expressed with extension methods.

          var studentsGroup2 = students.SelectByGroup();
          foreach (var student in studentsGroup2)
          {
              Console.WriteLine(student.FirstName);
          }

            Console.WriteLine();

            /*  Problem 11. Extract students by email
                Extract all students that have email in abv.bg.
                Use string methods and LINQ.
             */

            var studentsEmailAbv =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;
            foreach (var item in studentsEmailAbv)
            {
                Console.WriteLine(item.FirstName);
            }

            /* Problem 12. Extract students by phone

                Extract all students with phones in Sofia.
                Use LINQ.
             * */

            var studentsPhoneSofia =
                from student in students
                where student.PhoneNumber.StartsWith("02") || student.PhoneNumber.StartsWith("+3592")
                select student;

            //Problem 13. Extract students by marks
           //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
           //Use LINQ.

            var studentsExcellent =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            foreach (var student in studentsExcellent)
            {
                Console.WriteLine(student.FullName);
            }

            //Problem 14. Extract students with two marks
            //Write down a similar program that extracts the students with exactly two marks "2".
            //Use extension methods.

            var studentsGroup3 = students.ExtractTwoMarks();
            Console.WriteLine("Students with exactly two marks 2:");
            foreach (var student in studentsGroup2)
            {
                Console.WriteLine(student.FirstName);
            }

            Console.WriteLine();

           //Problem 15. Extract marks
           //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

            var students2006 =
                from student in students
                where student.FN.Substring(4,2)=="06"
                select student.Marks;

            foreach (var item in students2006)
            {
                foreach (var mark in item)
                {
                    Console.WriteLine(mark);
                }
                
            }

          //Problem 17. Longest string
          //Write a program to return the string with maximum length from an array of strings.
          //Use LINQ.

            string[] stringsArray = { "bla", "blabla", "blablabla" };
            string max = stringsArray.OrderByDescending(s => s.Length).First();
            Console.Write("Longest string: ");
            Console.WriteLine(max);

           //Problem 18. Grouped by GroupNumber
           //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
           //Use LINQ.

           Console.WriteLine(" With Linq");
            Console.WriteLine();
            var result = students.OrderBy(st => st.GroupNumber);
            foreach (var student in result)
            {
                Console.WriteLine("{0}, Group: {1}",student.FirstName,student.GroupNumber);
            }
            Console.WriteLine();
            Console.WriteLine("With extension");
            Console.WriteLine();
            //Using Extensions
            var resultWithExtensions = students.OrderByGroupNumber();
            foreach (var resultWithExtension in resultWithExtensions)
            {
                Console.WriteLine("{0}, Group: {1}", resultWithExtension.FirstName, resultWithExtension.GroupNumber);
            }










        }


        


    }
}
