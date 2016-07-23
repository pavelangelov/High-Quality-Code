using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        private const int Name_MinLength = 2;
        private const int Students_MaxCount = 30;

        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.Students = new HashSet<Student>();
        }

        public Course(string name, HashSet<Student> students)
            : this(name)
        {
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == null || value.Length < Name_MinLength)
                {
                    throw new ArgumentException("name");
                }
                this.name = value;
            }
        }

        public HashSet<Student> Students
        {
            get
            {
                return new HashSet<Student>(this.students);
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("students");
                }
                else if (value.Count > Students_MaxCount)
                {
                    throw new ArgumentOutOfRangeException("students");
                }
                this.students = value;
            }
        }

        public void AddStudent(Student studentToAdd)
        {
            if (studentToAdd == null)
            {
                throw new ArgumentNullException("studentToAdd");
            }

            if (this.Students.Count >= Students_MaxCount)
            {
                throw new ArgumentOutOfRangeException(string.Format("This course cannot add more than {0} students!", Students_MaxCount));
            }

            this.students.Add(studentToAdd);
        }

        public void RemoveStudent(Student studentToRemove)
        {
            if (studentToRemove == null)
            {
                throw new ArgumentNullException("studentToAdd");
            }

            this.students.Remove(studentToRemove);
        }
    }
}
