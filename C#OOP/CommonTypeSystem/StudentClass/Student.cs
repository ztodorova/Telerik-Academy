namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student : ICloneable, IComparable
    {

        private string firstName;
        private string middleName;
        private string lastName;
        private int sSN;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private int course;
        public UniversityEnum University { get; private set; }
        public FacultyEnum Faculty { get; private set; }
        public SpecialtyEnum Specialty { get; private set; }


        public Student(string firstName, string middleName, string lastName, int ssn, string permanentAddress, string mobilePhone
            , string email, int course, UniversityEnum university, FacultyEnum faculty, SpecialtyEnum specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.lastName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            private set
            {
                this.middleName = value;
            }
        }

        public int SSN
        {
            get
            {
                return this.sSN;
            }
            private set
            {
                this.sSN = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }
            private set
            {
                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            private set
            {
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                this.email = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }
            private set
            {
                this.course = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("First name:\t");
            result.AppendLine(this.FirstName);
            result.Append("Middle name:\t");
            result.AppendLine(this.MiddleName);
            result.Append("Last name:\t");
            result.AppendLine(this.LastName);
            result.Append("SSN:\t\t");
            result.AppendLine(this.SSN.ToString());
            result.Append("Address:\t");
            result.AppendLine(this.PermanentAddress);
            result.Append("Mobile Phone:\t");
            result.AppendLine(this.MobilePhone);
            result.Append("Email: \t\t");
            result.AppendLine(this.Email);
            result.Append("Course: \t");
            result.AppendLine(this.Course.ToString());
            result.Append("University: \t");
            result.AppendLine(this.University.ToString());
            result.Append("Faculty: \t");
            result.AppendLine(this.Faculty.ToString());
            result.Append("Specialty: \t");
            result.AppendLine(this.Specialty.ToString());

            return result.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.FirstName == secondStudent.FirstName &&
                firstStudent.MiddleName == secondStudent.MiddleName &&
                firstStudent.LastName == secondStudent.LastName &&
                firstStudent.SSN == secondStudent.SSN &&
                firstStudent.PermanentAddress == secondStudent.PermanentAddress &&
                firstStudent.MobilePhone == secondStudent.MobilePhone &&
                firstStudent.Email == secondStudent.Email &&
                firstStudent.Course == secondStudent.Course &&
                firstStudent.University == secondStudent.University &&
                firstStudent.Faculty == secondStudent.Faculty &&
                firstStudent.Specialty == secondStudent.Specialty
                )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.FirstName == secondStudent.FirstName &&
                firstStudent.MiddleName == secondStudent.MiddleName &&
                firstStudent.LastName == secondStudent.LastName &&
                firstStudent.SSN == secondStudent.SSN &&
                firstStudent.PermanentAddress == secondStudent.PermanentAddress &&
                firstStudent.MobilePhone == secondStudent.MobilePhone &&
                firstStudent.Email == secondStudent.Email &&
                firstStudent.Course == secondStudent.Course &&
                firstStudent.University == secondStudent.University &&
                firstStudent.Faculty == secondStudent.Faculty &&
                firstStudent.Specialty == secondStudent.Specialty
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override int GetHashCode()
        {

            return this.FirstName.GetHashCode() ^ this.SSN.GetHashCode();
        }

        public object Clone()
        {
            return new Student(
                this.FirstName as string,
                this.MiddleName as string,
                this.LastName as string,
                this.SSN,
                this.PermanentAddress as string,
                this.MobilePhone as string,
                this.Email as string,
                this.Course,
                this.University,
                this.Faculty,
                this.Specialty
                );
        }
        public int CompareTo(Object student)
        {
            var studentToCompare = student as Student;
            if (this.FirstName.CompareTo(studentToCompare.FirstName) < 0)
            {
                return -1;
            }
            else if (this.FirstName.CompareTo(studentToCompare.FirstName) > 0)
            {
                return 1;
            }

            else if (this.MiddleName.CompareTo(studentToCompare.MiddleName) < 0)
            {
                return -1;
            }

            else if (this.MiddleName.CompareTo(studentToCompare.MiddleName) > 0)
            {
                return 1;
            }
            else if (this.LastName.CompareTo(studentToCompare.LastName) < 0)
            {
                return -1;
            }
            else if (this.LastName.CompareTo(studentToCompare.LastName) > 0)
            {
                return 1;
            }
            else if (this.SSN.CompareTo(studentToCompare.SSN)<0)
            {
                return -1;
            }
            else if (this.SSN.CompareTo(studentToCompare.SSN) >0)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }
    }
}
