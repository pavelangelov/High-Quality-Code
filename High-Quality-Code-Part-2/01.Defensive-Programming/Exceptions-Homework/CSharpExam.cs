﻿using Exceptions_Homework.Utils;


public class CSharpExam : Exam
{
    private int score;

    /// <summary>
    /// Initializes a new instance of the <see cref="CSharpExam"/> class.
    /// </summary>
    /// <param name="score">The score from the exam.</param>
    public CSharpExam(int score)
    {
        this.Score = score;
    }

    /// <summary>
    /// Gets Score.
    /// </summary>
    public int Score
    {
        get
        {
            return this.score;
        }

        private set
        {
            string errorMsg = string.Format(ErrorMessages.NumberLessThanZeroErrorMessage, "score");

            Validator.CheckIfNumberIsLessThanZero(value, errorMsg);

            this.score = value;
        }
    }

    /// <summary>
    /// Creates and return new ExamResults.
    /// </summary>
    /// <returns>Returns new ExamResult.</returns>
    public override ExamResult Check()
    {
        string errorMsg = string.Format(ErrorMessages.ExamResultInvalidScoreMessage, 
                                        Constants.ExamResultMinScore, 
                                        Constants.ExamResultMaxScore);

        Validator.CheckIfNumberIsInRange(this.Score, 
                                        Constants.ExamResultMaxScore, 
                                        Constants.ExamResultMinScore, errorMsg);

        var result =  new ExamResult(this.Score, 
                                     Constants.ExamResultMinScore, 
                                     Constants.ExamResultMaxScore, 
                                     "Exam results calculated by score.");

        return result;
    }
}
