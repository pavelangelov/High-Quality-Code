using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace School.Tests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void Name_ShouldThrow_IfValueIsNull()
        {
            Assert.ThrowsException<ArgumentException>(() => new Course(null));
        }

        [TestMethod]
        public void Name_ShouldThrow_IfValueIsShorterThanTwoSymbols()
        {
            Assert.ThrowsException<ArgumentException>(() => new Course("A"));
        }

        [TestMethod]
        public void Name_ShouldSetValue_WhenItIsCorrect()
        {
            var name = "Unit Testing";
            var course = new Course(name);

            Assert.AreEqual(name, course.Name);
        }

        [TestMethod]
        public void AddStudent_ShouldThrow_IfStudentIsNull()
        {
            var course = new Course("HTML");

            Assert.ThrowsException<ArgumentNullException>(() => course.AddStudent(null));
            
        }

        [TestMethod]
        public void AddStudent_ShouldThrow_IfAddMoreThan30Students()
        {
            var students = Generator.GenerateSetOfStudents(30);
            var course = new Course("CSS");

            foreach (var student in students)
            {
                course.AddStudent(student);
            }

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => course.AddStudent(new Student("Ivan")));
        }

        [TestMethod]
        public void AddStudent_ShouldAddCorrectly30Students()
        {
            var numberOfStudents = 30;
            var students = Generator.GenerateSetOfStudents(numberOfStudents);
            var course = new Course("CSS");

            foreach (var student in students)
            {
                course.AddStudent(student);
            }

            Assert.AreEqual(numberOfStudents, course.Students.Count);
        }

        [TestMethod]
        public void RemoveStudent_ShouldThrow_IfValueIsNull()
        {
            var course = new Course("Some course");

            Assert.ThrowsException<ArgumentNullException>(() => course.RemoveStudent(null));
        }

        [TestMethod]
        public void RemoveStudent_ShouldRemoveCorrectly()
        {
            var course = new Course("Some other course");
            var student = new Student("Boris");

            course.AddStudent(student);
            course.RemoveStudent(student);

            Assert.AreEqual(0, course.Students.Count);

        }
    }
}
