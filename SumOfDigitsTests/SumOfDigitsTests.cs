using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfDigits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits.Tests
{
    [TestClass()]
    public class SumOfDigitsTests
    {
        [TestMethod()]
        public void SumDigitsTest1()
        {
            Assert.AreEqual(5, SumOfDigits.SumDigits(23)); 
        }
        [TestMethod()]
        public void SumDigitsTest2()
        {
            Assert.AreEqual(38, SumOfDigits.SumDigits(3276749));
        }
        [TestMethod()]
        public void SumDigitsTest3()
        {
            Assert.AreEqual(0, SumOfDigits.SumDigits(0));
        }
    }
}