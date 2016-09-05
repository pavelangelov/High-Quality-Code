using System.Collections.Generic;
using System.Text;

using Validation;

namespace InheritanceAndPolymorphism.Models
{
    public class LocalCourse : Course
    {
        private string lab;

        /// <summary>
        /// Create new instance of LocalCourse.
        /// </summary>
        /// <param name="courseName">The name of the course.</param>
        /// <param name="teacherName">The name of the teacher of the course.</param>
        /// <param name="lab">The name of the course`s hall.</param>
        public LocalCourse(string courseName, string teacherName, string lab)
            : base(courseName, teacherName)
        {
            this.Lab = lab;
        }

        /// <summary>
        /// Create new instance of LocalCourse.
        /// </summary>
        /// <param name="courseName">The name of the course.</param>
        /// <param name="teacherName">The name of the teacher of the course.</param>
        /// <param name="lab">The name of the course`s hall.</param>
        /// <param name="students">Enrolled student for this course.</param>
        public LocalCourse(string courseName, string teacherName, string lab, IList<string> students)
            :base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        /// <summary>
        /// The name of the course`s hall.
        /// </summary>
        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                Validator.CheckForNullOrEmpty(value, "lab");
                Validator.CheckStringLength(value, Constants.LabMaxLength, Constants.LabMinLength, "lab");

                this.lab = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder(base.ToString());

            result.Append($"Lab = {this.Lab} }}");
            return result.ToString();
        }
    }
}
