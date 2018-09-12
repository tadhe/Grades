using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Test.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void AddDayToDateTime2()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date.AddDays(1);

            Assert.AreNotEqual(2, date.Day);
        }

        [TestMethod]
        public void AddDayToDateTime()
        {
            DateTime date = new DateTime(2015,1,1);
            date = date.AddDays(1);

            Assert.AreEqual(2,date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);

            Assert.AreEqual(47,x);
        }

        private void IncrementNumber(ref int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypePassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(ref book2);
            Assert.AreEqual("A GradeBook",book2.Name);
        }

        private void GiveBookAName(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A GradeBook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "scott";
            string name2 = "Scott";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1,x2);
        }
        
        [TestMethod]
        public void GradeBookVariablesHoldReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "The Book No1";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
