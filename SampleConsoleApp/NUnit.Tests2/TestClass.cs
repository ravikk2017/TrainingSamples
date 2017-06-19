using System;
using NUnit.Framework;
using SampleConsoleApp;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        int result = 0;
        [TestCase(10, 20, 200)]
        [TestCase(20, 30, 600)]
        [TestCase(5,6,30)]
        [TestCase(5,5,25)]
        public void TestMethod(int n1, int n2, int expected)
        {
            // TODO: Add your test code here
            result = Program.ProdNumbers(n1, n2);
            Assert.AreEqual(expected, result);
        }
        [TestCase(20,5, ExpectedResult = 4)]
        [TestCase(30,5, ExpectedResult = 6)]
        [TestCase(10,0, ExpectedResult = 0, Ignore = "Exception not tested now")]
        public int TestDivideMethod(int n1, int n2)
        {
            return Program.DivideNumbers(n1, n2);
        }
    }
}
