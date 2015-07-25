using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolClasses
{
    public class Class : School
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private string textIdentifier;

        public Class(string textIdentifier) : base()
        {
            this.TextIdentifier = textIdentifier;
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
        }

        public Class(string textId, string comment) : base(comment)
        {
            this.TextIdentifier = textIdentifier;
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
        }

        public List<Teacher> Teachers
        {
            get
            {
                return teachers;
            }
            set
            {
                this.teachers = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            set
            {
                this.textIdentifier = value;
            }
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.Teachers.Remove(teacher);
        }
    }
}
