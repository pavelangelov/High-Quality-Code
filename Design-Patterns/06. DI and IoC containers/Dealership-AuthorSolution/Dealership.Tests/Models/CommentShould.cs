using Dealership.Models;
using NUnit.Framework;

namespace Dealership.Tests.Models
{
    [TestFixture]
    public class CommentShould
    {
        [Test]
        public void _CreateNewComment_WithValidProperties_IfPassedParametersAreValid()
        {
            // Arrange, Act
            var content = "Some commetn";
            var author = "Myself";

            var comment = new Comment(content);
            comment.Author = author;

            // Assert
            Assert.AreEqual(typeof(Comment), comment.GetType());
            Assert.AreEqual(content, comment.Content);
            Assert.AreEqual(author, comment.Author);
        }
    }
}
