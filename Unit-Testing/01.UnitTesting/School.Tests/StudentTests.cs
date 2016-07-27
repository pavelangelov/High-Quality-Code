using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void Name_ShouldThrow_IfValueIsNull()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student(null));
        }

        [TestMethod]
        public void Name_ShouldThrow_IfValueIsLessThanTwoSymbols()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student("A"));
        }

        [TestMethod]
        public void Name_ShouldSetValue_WhrnItIsCorrect()
        {
            string name = "Ivan";
            var student = new Student(name);

            Assert.AreEqual(name, student.Name);
        }

        [TestMethod]
        public void Id_ShouldBeUniq()
        {
            var firstStudent = new Student("Petyr");
            var secondStudent = new Student("Pavel");

            Assert.AreNotEqual(firstStudent.Id, secondStudent.Id);
        }

        [TestMethod]
        public void AddCourse_ShouldThrow_IfCourseIsNull()
        {
            var student = new Student("Krasimir");

            Assert.ThrowsException<ArgumentNullException>(() => student.AddCourse(null));
        }

        [TestMethod]
        public void AddCourse_ShouldAddCourse_WhenItIsCorrect()
        {
            var student = new Student("Pavel");
            var course = new Course("C# Basics");

            student.AddCourse(course);

            Assert.AreEqual(1, student.ViewCourses().Count);
        }

        [TestMethod]
        public void RemoveCourse_ShouldThrow_IfValueIsNull()
        {
            var student = new Student("John");

            Assert.ThrowsException<ArgumentNullException>(() => student.RemoveCourse(null));
        }

        [TestMethod]
        public void RemoveCourse_ShouldRemoveCourse_WhenItIsCorrect()
        {
            var student = new Student("Simona");
            var firstCourse = new Course("C# Advanced");
            var secondCourse = new Course("C# OOP");

            student.AddCourse(firstCourse);
            student.AddCourse(secondCourse);
            student.RemoveCourse(firstCourse);

            Assert.IsFalse(student.ViewCourses().Contains(firstCourse));
        }

        [TestMethod]
        public void ViewCourses_ShouldWorkCorrectly()
        {
            var student = new Student("Natali");
            var firstCourse = new Course("JS Applications");
            var secondCourse = new Course("JS OOP");

            student.AddCourse(firstCourse);
            student.AddCourse(secondCourse);

            Assert.AreEqual(2, student.ViewCourses().Count);
        }
    }
}
