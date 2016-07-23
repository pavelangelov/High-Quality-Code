using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{

    public class Student
    {
        private string name;
        private int id;

        public Student(string name)
        {
            this.Name = name;
            this.id = Generator.GeneradeId();
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

        public override string ToString()
        {
            return string.Format("Name: {0}, ID: {1}", this.Name, this.Id);
        }
    }
}



