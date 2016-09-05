using Validation;

namespace Cohesion_and_Coupling.Utils
{
    public static class FileUtils
    {
        private const string MissingFileExtensionMessage = "File name \"{0}\" doesn`t contain file extension!";

        /// <summary>
        /// Get the file extension from passed file name.
        /// </summary>
        /// <param name="fileName">File name where to check.</param>
        /// <returns>Returns string.</returns>
        public static string GetFileExtension(string fileName)
        {
            var message = string.Format(MissingFileExtensionMessage, fileName);
            Validator.CheckFileNameForFileExtension(fileName, message);

            int indexOfLastDot = fileName.LastIndexOf(".");
            string extension = fileName.Substring(indexOfLastDot + 1);

            return extension;
        }

        /// <summary>
        /// Returns new string, contains only the name of the file without file extension.
        /// </summary>
        /// <param name="fileName">File name where to check.</param>
        /// <returns>Returns string.</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            var message = string.Format(MissingFileExtensionMessage, fileName);
            Validator.CheckFileNameForFileExtension(fileName, message);

            int indexOfLastDot = fileName.LastIndexOf(".");
            string extension = fileName.Substring(0, indexOfLastDot);

            return extension;
        }
    }
}
