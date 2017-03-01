using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsDemo;

namespace JenkinsDemo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mw = new MyWork();
            Assert.AreEqual(mw.DoSomething(1), 1);
            Assert.AreEqual(mw.DoSomething(100), 100);
        }
    }
}
