using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 9. Student groups

Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
Create a List<Student> with sample students. Select only the students that are from group number 2.
Use LINQ query. Order the students by FirstName.
*/

namespace StudentGroup
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, string fn,string phone,string email,int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.PhoneNumber = phone;
            this.Email = email;
            this.Marks = new List<int>();
            this.GroupNumber = groupNumber;
        }
    }
}
