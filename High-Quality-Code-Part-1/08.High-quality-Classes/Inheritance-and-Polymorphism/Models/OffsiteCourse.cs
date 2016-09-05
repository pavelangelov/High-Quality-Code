using System.Collections.Generic;
using System.Text;

using Validation;

namespace InheritanceAndPolymorphism.Models
{
    public class OffsiteCourse : Course
    {
        private string town;

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class.
        /// </summary>
        /// <param name="courseName">The name of the course.</param>
        /// <param name="teacherName">The name of the teacher of the course.</param>
        /// <param name="town">The town where the course is conducted.</param>
        public OffsiteCourse(string courseName, string teacherName, string town)
            : base(courseName, teacherName)
        {
            this.Town = town;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class.
        /// </summary>
        /// <param name="courseName">The name of the course.</param>
        /// <param name="teacherName">The name of the teacher of the course.</param>
        /// <param name="town">The town where the course is conducted.</param>
        /// <param name="students">Enrolled student for this course.</param>
        public OffsiteCourse(string courseName, string teacherName, string town, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        /// <summary>
        /// Gets or sets the town where the course is conducted.
        /// </summary>
        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                Validator.CheckForNullOrEmpty(value, "town");
                Validator.CheckStringLength(value, Constants.TownMaxLength, Constants.TownMinLength, "town");

                this.town = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder(base.ToString());

            result.Append($"Town = {this.Town} }}");

            return result.ToString();
        }
    }
}
