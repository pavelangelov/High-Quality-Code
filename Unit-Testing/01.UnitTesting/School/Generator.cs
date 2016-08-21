using System.Collections.Generic;

namespace School
{
    public class Generator
    {
        private static int id = 10000;

        public static int GeneradeId()
        {
            return id++;
        }

        public static HashSet<Student> GenerateSetOfStudents(int length)
        {
            HashSet<Student> students = new HashSet<Student>();
            string name = "Pesho #";
            for (int i = 0; i < length; i++)
            {
                Student st = new Student(name + (i + 1));
                students.Add(st);
            }


            return students;
        }
    }
}
