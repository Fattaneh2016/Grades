
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Tests.Type
{
    [TestClass]
    public class TypeTests
    {

        [TestMethod]

        public void UpperCaseString()
        {
            string name = "fati";
            name = name.ToUpper();

            Assert.AreEqual("FATI", name);
        }
        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2017, 1, 1);
            date = date.AddDays(1);
            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void ValueTypePassByValue()
        {
            int x = 45;
            IncrementNumber(x);
            Assert.AreEqual(45, x);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }
        [TestMethod]
        public void ReferenceTypePassByValue()
        {
            GradeBook book1 = new GradeBook();

            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("grade book", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "grade book";
        }
        [TestMethod]
        public void StringComparison()
        {
            string name1 = "Farah";
            string name2 = "Farah";


            bool result = string.Equals(name1, name2, System.StringComparison.InvariantCultureIgnoreCase);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void VariableHoldReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "fattaneh ameri";
            Assert.AreEqual(g1.Name, g2.Name);

        }

    }

}
