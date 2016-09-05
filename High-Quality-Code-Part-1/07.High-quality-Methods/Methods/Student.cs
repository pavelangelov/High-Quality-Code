using System;

namespace Methods
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Student(string firstName, string lastName, int age, string otherInfo)
            : this(firstName, lastName, age)
        {
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("firstName");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("firstName");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public string OtherInfo { get; set; }

        /// <summary>
        /// Compare students by age. Returns true if current student is older than passed one, else return false.
        /// </summary>
        /// <param name="otherStudent">Student to compare.</param>
        /// <returns>Return boolean.</returns>
        public bool IsOlderThan(Student otherStudent)
        {
            bool isOlder = this.Age > otherStudent.Age;

            return isOlder;
        }
    }
}
