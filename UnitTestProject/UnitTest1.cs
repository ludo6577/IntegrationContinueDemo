using System;
using ConsoleApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFibo0()
        {
            Assert.AreEqual(0, Program.Fibo(0));
        }

        [TestMethod]
        public void TestFibo1()
        {
            Assert.AreEqual(1, Program.Fibo(1));
        }

        [TestMethod]
        public void TestFibo5()
        {
            Assert.AreEqual(5, Program.Fibo(5));
        }

        [TestMethod]
        public void TestFibo13()
        {
            Assert.AreEqual(233, Program.Fibo(13));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A userId of null was inappropriately allowed.")]
        public void TestFiboNegatif()
        {
            Program.Fibo(-1);
        }
    }
}
