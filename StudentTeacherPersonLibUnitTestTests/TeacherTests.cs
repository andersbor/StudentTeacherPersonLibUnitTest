using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentTeacherPersonLibUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherPersonLibUnitTest.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        private Teacher teacher = new Teacher { Id = 1, Name = "Y", Salary = 0 };
        private Teacher teacher2 = new Teacher { Id = 1, Name = "", Salary = 0 };

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual("1 Y 0", teacher.ToString());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            teacher.Validate();   
            Assert.ThrowsException<ArgumentException>(() => teacher2.Validate());
        }
    }
}