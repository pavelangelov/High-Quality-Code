using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using School;

namespace School.Tests
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void Student_ShouldThrow_IfNameIsNull()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student(null));
        }

        [TestMethod]
        public void Student_ShouldThrow_WhenNameIsLessThanTwoSybols()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student("C"));
        }

        [TestMethod]
        public void StudentId_ShouldBeUniq()
        {
            Student first = new Student("Pesho");
            Student second = new Student("Ivan");

            Assert.AreNotEqual(first.Id, second.Id);
        }

        [TestMethod]
        public void Student_ShouldSetName_WhenItIsCorrect()
        {
            string studentName = "Ivan";

            Student st = new Student(studentName);

            Assert.AreEqual(studentName, st.Name);
        }

        [TestMethod]
        public void Course_ShouldThrow_WhenNameIsNull()
        {
            Assert.ThrowsException<ArgumentException>(() => new Course(null));
        }

        [TestMethod]
        public void Course_ShouldThrow_WhenNameIsLessThanTwoSymbols()
        {
            Assert.ThrowsException<ArgumentException>(() => new Course("A"));
        }

        [TestMethod]
        public void Course_ShouldThrow_WhenStudentsListIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Course("Unit Testing", null));
        }

        [TestMethod]
        public void Course_ShouldSetName_WhenNameIsCorrect()
        {
            string courseName = "Unit Testing";
            Course course = new Course(courseName);

            Assert.AreEqual(courseName, course.Name);
        }

        [TestMethod]
        public void Course_ShouldSetStudents_WhenStudentsListIsCorrect()
        {
            HashSet<Student> students = new HashSet<Student>();

            students.Add(new Student("Pesho"));
            Course course = new Course("Unit Testing", students);

            Assert.AreEqual(1, course.Students.Count);
        }

        [TestMethod]
        public void Course_ShouldThrow_WhenAddedStudentIsNull()
        {
            Course course = new Course("JS OOP");

            Assert.ThrowsException<ArgumentNullException>(() => course.AddStudent(null));
        }

        [TestMethod]
        public void Course_ShouldThrow_WhenSetMoreThan30Students()
        {
            HashSet<Student> students = Generator.GenerateSetOfStudents(31);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Course("Unit Testing", students));
        }

        [TestMethod]
        public void Course_ShouldThrow_WhenAddMoreThan30Students()
        {
            HashSet<Student> students = Generator.GenerateSetOfStudents(30);
            Course course = new Course("JS OOP", students);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => course.AddStudent(new Student("Gosho")));
        }

        [TestMethod]
        public void Course_ShouldContain_AddedStudent()
        {
            Student st = new Student("Tosho");
            Course course = new Course("Unit Testing");

            course.AddStudent(st);

            Assert.IsTrue(course.Students.Contains(st));
        }

        [TestMethod]
        public void Course_ShouldAddCorrectly30Students()
        {
            int numberOfStudents = 30;
            HashSet<Student> students = Generator.GenerateSetOfStudents(numberOfStudents);
            Course course = new Course("JS OOP", students);

            Assert.AreEqual(numberOfStudents, course.Students.Count);
        }

        [TestMethod]
        public void Course_ShouldThrow_WhenRemovedStudentIsNull()
        {
            int numberOfStudents = 30;
            HashSet<Student> students = Generator.GenerateSetOfStudents(numberOfStudents);
            Course course = new Course("JS OOP", students);

            Assert.ThrowsException<ArgumentNullException>(() => course.RemoveStudent(null));
        }

        [TestMethod]
        public void Course_ShouldRemoveStudent_WhenStudentIsCorrect()
        {
            Course course = new Course("JS OOP");
            Student st = new Student("Pesho");

            course.AddStudent(st);
            course.RemoveStudent(st);

            Assert.AreEqual(0, course.Students.Count);
        }

        [TestMethod]
        public void Course_ShouldNotContain_RemovedStudent()
        {
            Course course = new Course("JS OOP");
            Student first = new Student("Pesho");
            Student second = new Student("Gosho");

            course.AddStudent(first);
            course.AddStudent(second);
            course.RemoveStudent(first);

            Assert.IsFalse(course.Students.Contains(first));
        }
    }
}
