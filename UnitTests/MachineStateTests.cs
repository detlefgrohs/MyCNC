using System;
using MachineController;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class MachineStateTests
    {
        [TestMethod]
        public void MachineStateDefaultTest()
        {
            MachineState machineState = new MachineState();

            Assert.AreEqual(@"Units: Inches
Minimum: X0.0 Y0.0 Z0.0
Maximum: X0.0 Y0.0 Z0.0", machineState.ToString());
        }

        [TestMethod]
        public void MachineStateTest()
        {
            MachineState machineState = new MachineState();

            machineState.UnitsAreMM = true;
            machineState.Minimum = new TripleDouble
            {
                X = 1.0,
                Y = 2.0,
                Z = 3.0
            };
            machineState.Maximum = new TripleDouble
            {
                X = 4.0,
                Y = 5.0,
                Z = 6.0
            };

            Assert.AreEqual(@"Units: MM
Minimum: X1.0 Y2.0 Z3.0
Maximum: X4.0 Y5.0 Z6.0", machineState.ToString());
        }
    }
}
