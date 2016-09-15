using System;
using System.Linq;
using System.Collections.Generic;

using Exceptions_Homework.Utils;

public class Student
{
    private string firstName;
    private string lastName;
    private IList<Exam> exams;

    /// <summary>
    /// Initializes a new instance of the <see cref="Student"/> class.
    /// </summary>
    /// <param name="firstName">First name of the student.</param>
    /// <param name="lastName">Last name of the student.</param>
    public Student(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.exams = new List<Exam>();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Student"/> class.
    /// </summary>
    /// <param name="firstName">First name of the student.</param>
    /// <param name="lastName">Last name of the student.</param>
    /// <param name="exams">Exams of the student.</param>
    public Student(string firstName, string lastName, IList<Exam> exams)
        : this(firstName, lastName)
    {
        this.Exams = exams;
    }

    /// <summary>
    /// Gets or sets FirstName.
    /// </summary>
    /// <exception cref="ArgumentException"/>
    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            Validator.CheckStringForNullOrEmpty(value, "Student firstName cannot be null or empty string!");

            this.firstName = value;
        }
    }

    /// <summary>
    /// Gets or sets LastName.
    /// </summary>
    /// <exception cref="ArgumentException"/>
    public string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            Validator.CheckStringForNullOrEmpty(value, "Student lastName cannot be null or empty string!");

            this.lastName = value;
        }
    }

    /// <summary>
    /// Gets Exams.
    /// </summary>
    /// <exception cref="NullReferenceException"/>
    public IList<Exam> Exams
    {
        get
        {
            return new List<Exam>(this.exams);
        }

        private set
        {
            Validator.CheckForNull(value, "Student exams cannot be null!");

            this.exams = value;
        }
    }

    /// <summary>
    /// Add exam to this instance of the class  <see cref="Student"/>.
    /// </summary>
    /// <param name="examToAdd">Exam to add.</param>
    public void AddExam(Exam examToAdd)
    {
        Validator.CheckForNull(examToAdd, "Student examToAdd cannot be null!");

        this.exams.Add(examToAdd);
    }

    /// <summary>
    /// Add colection of exams to this instance of the class  <see cref="Student"/>.
    /// </summary>
    /// <param name="examsToAdd">Collection of exams to add.</param>
    public void AddExams(IList<Exam> examsToAdd)
    {
        foreach (var exam in examsToAdd)
        {
            this.AddExam(exam);
        }
    }

    /// <summary>
    /// Checks all exams of this instance of the class <see cref="Student"/> and returns it in new IList of ExamResult.
    /// </summary>
    /// <returns>Returns <see cref="IList{T}"/></returns>
    /// <exception cref="InvalidOperationException"/>
    public IList<ExamResult> CheckExams()
    {
        if (this.Exams.Count == 0)
        {
            throw new InvalidOperationException("The student has no exams!");
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    /// <summary>
    /// Calculates the average exam result in percents and return it. If there is no exams to calculate returns 0.
    /// </summary>
    /// <returns>Returns double.</returns>
    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams.Count == 0)
        {
            return 0;
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
