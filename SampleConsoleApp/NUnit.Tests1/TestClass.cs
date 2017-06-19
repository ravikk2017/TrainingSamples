using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleConsoleApp;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        int result = 0;
        [SetUp]
        [TestCase(10,20,200)]
        [TestCase(20,30,100)]
        public void TestMethod(int n1,int n2,int expected)
        {
            // TODO: Add your test code here
            result = Program.ProdNumbers(n1, n2);
            Assert.AreEqual(expected, result);
        }
    }
}
