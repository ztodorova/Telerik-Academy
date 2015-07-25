using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    public static class ExtentionStudentList
    {
        
        //Problem 10. Student groups extensions

        //Implement the previous using the same query expressed with extension methods.

        public static IEnumerable<Student> SelectByGroup(this IList<Student> list)
        {
            var studentGroup =
                 from student in list
                 where student.GroupNumber == 2
                 orderby student.FirstName
                 select student;

            return studentGroup;
        }


        //Problem 14. Extract students with two marks
        //Write down a similar program that extracts the students with exactly two marks "2".
        //Use extension methods.

        public static List<Student> ExtractTwoMarks(this List<Student> input)
        {
            List<Student> result = new List<Student>();
            for (int i = 0; i < input.Count; i++)
            {
                int current2 = 0;
                for (int j = 0; j < input[i].Marks.Count; j++)
                {
                    if (input[i].Marks[j] == 2)
                        current2++;
                }
                if (current2 >= 2)
                {
                    result.Add(input[i]);
                }
            }
            return result;
        }



        public static IEnumerable<Student> OrderByGroupNumber(this List<Student> input)
        {
            var result = input.OrderBy(st => st.GroupNumber);
            return result;
        }
    }
         
    
}
