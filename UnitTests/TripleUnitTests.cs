using System;
using MachineController;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TripleUnitTests
    {
        [TestMethod]
        public void TripleDoubleDefaultTest()
        {
            TripleDouble triple = new TripleDouble();

            Assert.AreEqual(@"X0.0 Y0.0 Z0.0", triple.ToString());
        }

        [TestMethod]
        public void TripleDoubleTest()
        {
            TripleDouble triple = new TripleDouble
            {
                X = 125.5,
                Y = 1024.125
            };

            Assert.AreEqual(@"X125.5 Y1024.125 Z0.0", triple.ToString());
        }

        [TestMethod]
        public void TripleIntDefaultTest()
        {
            TripleInt triple = new TripleInt();

            Assert.AreEqual(@"X0 Y0 Z0", triple.ToString());
        }

        [TestMethod]
        public void TripleIntTest()
        {
            TripleInt triple = new TripleInt
            {
                X = 125,
                Y = 1024
            };

            Assert.AreEqual(@"X125 Y1024 Z0", triple.ToString());
        }
    }
}
