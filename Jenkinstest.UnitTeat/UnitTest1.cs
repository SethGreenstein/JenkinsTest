using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jenkinstest.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ts = new jenkinstest.TestService();

            Assert.AreSame("Continuous Integration is Awesome!!", ts.GetMessage());


        }
    }
}
