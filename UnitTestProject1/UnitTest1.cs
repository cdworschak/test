using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Year Year = null;

        [TestInitialize]
        public void Init()
        {
            Year = new Year();
        }        

        [TestMethod]
        public void Valid_leap_year()
        {
            Assert.IsTrue(Year.IsLeap(1996));
        }

        //[Ignore]
        [TestMethod]
        public void Invalid_leap_year()
        {
            Assert.IsFalse(Year.IsLeap(1997));
        }

        //[Ignore]
        [TestMethod]
        public void Turn_of_the_20th_century_is_not_a_leap_year()
        {
            Assert.IsFalse(Year.IsLeap(1900));
        }

        //[Ignore]
        [TestMethod]
        public void Turn_of_the_25th_century_is_a_leap_year()
        {
            Assert.IsTrue(Year.IsLeap(2400));
        }

        //[Ignore]
        [TestMethod]
        public void Year0()
        {
            Assert.IsTrue(Year.IsLeap(0));
        }

        [Ignore]
        [TestMethod]
        public void TestDivideByZero()
        {
            Assert.IsFalse(5.IsDivisibleBy(0));
        }
    }
}

