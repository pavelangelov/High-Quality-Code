using System.Collections.Generic;
using System.Text;

using Validation;

namespace InheritanceAndPolymorphism.Models
{
    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;
        
        protected Course(string courseName, string teacherName)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.students = new List<string>();
        }

        protected Course(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName)
        {
            this.Students = students;
        }

        /// <summary>
        /// The name of the course.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckForNullOrEmpty(value, "courseName");
                Validator.CheckStringLength(value, Constants.CourseNameMaxLength, Constants.CourseNameMinLength, "courseName");

                this.name = value;
            }
        }

        /// <summary>
        /// Teacher`s name.
        /// </summary>
        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            private set
            {
                Validator.CheckForNullOrEmpty(value, "teacherName");
                Validator.CheckStringLength(value, Constants.NameMaxLength, Constants.NameMinLength, "teacherName");

                this.teacherName = value;
            }
        }

        /// <summary>
        /// Enrolled student for this course.
        /// </summary>
        public IList<string> Students
        {
            get
            {
                return new List<string>(this.students);
            }

            protected set
            {
                Validator.CheckForNull(value, "students");
                foreach (var student in value)
                {
                    Validator.CheckStringLength(student, Constants.NameMaxLength, Constants.NameMinLength);
                }

                this.students = value;
            }
        }

        /// <summary>
        /// Adds new student to the course.
        /// </summary>
        /// <param name="studentName">Student to add.</param>
        public virtual void Add(string studentName)
        {
            Validator.CheckForNullOrEmpty(studentName, "studentName");
            Validator.CheckStringLength(studentName, Constants.NameMaxLength, Constants.NameMinLength, "studentName");

            this.students.Add(studentName);
        }

        /// <summary>
        /// Adds group of students to the course.
        /// </summary>
        /// <param name="studentsToAdd">Students to add.</param>
        public virtual void AddStudents(IList<string> studentsToAdd)
        {
            Validator.CheckForNull(studentsToAdd, "studentsToAdd");

            foreach (var student in studentsToAdd)
            {
                Validator.CheckForNullOrEmpty(student, "studentsToAdd");
                Validator.CheckStringLength(student, Constants.NameMaxLength, Constants.NameMinLength, "studentsToAdd");

                this.students.Add(student);
            }
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"OffsiteCourse {{ Name = {this.Name}; Teacher = {this.TeacherName}; ");

            if (this.students.Count > 0)
            {
                result.Append("Students = ");
                result.Append(this.GetStudentsAsString());
                result.Append("; ");
            }

            return result.ToString();
        }
    }
}
