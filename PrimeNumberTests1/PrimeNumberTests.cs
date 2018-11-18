using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber.Tests
{
    [TestClass()]
    public class PrimeNumberTests
    {
        [TestMethod()]
        public void IsPrimeTest1()
        {
            Assert.IsTrue(PrimeNumber.IsPrime(7));
        }
        [TestMethod()]
        public void IsPrimeTest2()
        {
            Assert.IsFalse(PrimeNumber.IsPrime(16));
        }
        [TestMethod()]
        public void IsPrimeTest3()
        {
            Assert.IsFalse(PrimeNumber.IsPrime(255));
        }
        [TestMethod()]
        public void IsPrimeTest4()
        {
            Assert.IsTrue(PrimeNumber.IsPrime(97));
        }
    }
}