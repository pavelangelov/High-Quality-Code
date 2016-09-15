using Exceptions_Homework.Utils;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    /// <summary>
    /// Initializes a new instance of the <see cref="ExamResult"/> class.
    /// </summary>
    /// <param name="grade"></param>
    /// <param name="minGrade"></param>
    /// <param name="maxGrade"></param>
    /// <param name="comments"></param>
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    /// <summary>
    /// Gets Grade.
    /// </summary>
    public int Grade
    {
        get
        {
            return this.grade;
        }

        private set
        {
            string errorMsg = string.Format(ErrorMessages.NumberLessThanZeroErrorMessage, "grade");
            Validator.CheckIfNumberIsLessThanZero(value);

            this.grade = value;
        }
    }

    /// <summary>
    /// Gets minimum possible grade.
    /// </summary>
    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            string errorMsg = string.Format(ErrorMessages.NumberLessThanZeroErrorMessage, "minGrade");
            Validator.CheckIfNumberIsLessThanZero(value, errorMsg);

            this.minGrade = value;
        }
    }

    /// <summary>
    /// Gets maximum possible grade.
    /// </summary>
    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }

        private set
        {
            Validator.CheckIfNumberIsEqualOrGreaterThanOtherNumber(value, this.MinGrade, ErrorMessages.ExamResultMaxGradeErrorMessage);

            this.maxGrade = value;
        }
    }

    /// <summary>
    /// Gets comments.
    /// </summary>
    public string Comments
    {
        get
        {
            return this.comments;
        }

        private set
        {
            string errorMsg = string.Format(ErrorMessages.StringNullOrEmpryErrorMessage, "comments");
            Validator.CheckStringForNullOrEmpty(value, errorMsg);

            this.comments = value;
        }
    }

}
