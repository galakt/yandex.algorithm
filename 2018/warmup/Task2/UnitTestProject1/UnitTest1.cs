using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool b = false;
            Assert.IsTrue(Program.IsPol("aa".ToCharArray(), 0, 2, ref b, null));
            Assert.IsTrue(Program.IsPol("baa".ToCharArray(), 1, 2, ref b, null));
            Assert.IsTrue(Program.IsPol("baag".ToCharArray(), 1, 2, ref b, null));
            Assert.IsTrue(Program.IsPol("aab".ToCharArray(), 0, 2, ref b, null));
        }

        [TestMethod]
        public void Test1()
        {
            Assert.IsTrue(Program.GetPalindrome("bbbaa").SequenceEqual("aa"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.IsTrue(Program.GetPalindrome("abab").SequenceEqual("aba"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.IsTrue('a' < 'b');
        }
    }
}
