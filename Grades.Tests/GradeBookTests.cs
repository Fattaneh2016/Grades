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
            book.AddGrade(1);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(56, result.HighestGrade);

        }
        [TestMethod]
        public void ComputelowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(56);
            book.AddGrade(24);
            book.AddGrade(1);


            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(1, result.Lowestgrade);
        }
        [TestMethod]
        public void ComputeAGradeverage()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(45);
            book.AddGrade(87.9f);
            book.AddGrade(40);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(57.63, result.AverageGrade, 0.01);
        }
    }
}
