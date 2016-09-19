using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace StateMachine.Tests
{
    [TestClass]
    public class FiniteStateMachineTests
    {
        [TestMethod]
        public void Test1()
        {
            var sm = new FiniteStateMachine();
            Assert.IsTrue(sm.Method());
        }
    }
}