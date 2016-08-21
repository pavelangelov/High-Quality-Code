using System;
using System.Collections.Generic;

namespace School
{
    public class Student
    {
        private string name;
        private int id;
        private ICollection<Course> courses;

        public Student(string name)
        {
            this.Name = name;
            this.id = Generator.GeneradeId();
            this.courses = new HashSet<Course>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == null || value.Length < 2)
                {
                    throw new ArgumentException("The name cannot be null and must be larger than 2 symbols!");
                }
                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (value < 10000 && value > 99999)
                {
                    throw new ArgumentException("The student id must be between 10000 and 99999!");
                }
                this.id = value;
            }
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course");
            }
            this.courses.Add(course);
            course.AddStudent(this);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course");
            }
            this.courses.Remove(course);
            course.RemoveStudent(this);
        }

        /// <summary>
        /// View student courses
        /// </summary>
        /// <returns>List<Course></Course></returns>
        public List<Course> ViewCourses()
        {
            return new List<Course>(this.courses);
        }
    }
}



