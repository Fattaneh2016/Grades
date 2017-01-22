using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(56);
            book.AddGrade(24);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(56, result.HighestGrade);

        }


    }
}
