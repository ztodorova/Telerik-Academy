using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentClass
{
    class StudentClassMain
    {
       public static void Main()
        {
            Student pesho = new Student("pesho","pehov","goshov",555,"Ul Marica","53646546","fdsdf@fdf.vfv",4,UniversityEnum.TechnicalUniversity,FacultyEnum.Mathematics,SpecialtyEnum.IT);
            Student secondPesho = new Student("pesho", "pehov", "goshov", 555, "Ul Marica", "53646546", "fdsdf@fdf.vfv", 4, UniversityEnum.TechnicalUniversity, FacultyEnum.Mathematics, SpecialtyEnum.IT);
            Student gosho = new Student("gosho", "pehov", "goshov", 5453555, "Ul Rarica", "53644456546", "fdsfdfdf@fdf.vfv", 4, UniversityEnum.TechnicalUniversity, FacultyEnum.Mathematics, SpecialtyEnum.IT);
            Console.WriteLine(pesho.ToString());

            if (pesho==secondPesho)
            {
                Console.WriteLine("Operator == works fine!");
            }
            if (pesho!=secondPesho)
            {
                Console.WriteLine("Doesn't work");
            }
            else
            {
                Console.WriteLine("Operator != works fine!");
            }

            Console.WriteLine();
            Console.Write("Equals method: ");
            Console.WriteLine(pesho.Equals(secondPesho));
            Console.WriteLine();
            Console.Write("Pesho get hash code method: ");
            Console.WriteLine(pesho.GetHashCode());
            Console.Write("Gosho get hash code method: ");
            Console.WriteLine(gosho.GetHashCode());
            Console.WriteLine();
            Console.WriteLine("Copy of pesho:");

            Student peshoCopy = pesho.Clone() as Student;
            Console.WriteLine(peshoCopy);

            Console.Write("Pesho compare to copy of pesho: ");
            Console.WriteLine(pesho.CompareTo(peshoCopy));
            
        }
       
    }
}
