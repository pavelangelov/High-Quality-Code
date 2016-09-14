namespace Exceptions_Homework.Utils
{
    internal class ErrorMessages
    {
        internal const string NumberLessThanZeroErrorMessage = "The {0} must be equal or greater than 0!";
        internal const string ExamResultInvalidScoreMessage = "The score from exam must be between {0} and {1}!";
        internal const string ExamResultMaxGradeErrorMessage = "MaxGrade cannot be less or equal to minGrade value.";

        internal const string StringNullOrEmpryErrorMessage = "The {0} cannot be null, empty or string contains only white-spaces.";
    }
}
