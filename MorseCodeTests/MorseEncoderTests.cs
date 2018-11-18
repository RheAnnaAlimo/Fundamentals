using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorseCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode.Tests
{
    [TestClass()]
    public class MorseEncoderTests
    {
        [TestMethod()]
        public void EncoderTest()
        {
            Assert.AreEqual(".... -.. .-.. .-.. ---   .-- --- .-. .-.. -.-.", MorseEncoder.Encoder("Hello world"));
        }
    }
}