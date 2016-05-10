using System;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class PopperTest
    {
        [TestMethod]
        public void TestDefault()
        {
            int item = 1;
            Popper p = new Popper();
            string actual = p.apply(item);
            Assert.AreEqual("1", actual);
        }
        [TestMethod]
        public void TestFizz()
        {
            int item = 3;
            Popper p = new Popper();
            string actual = p.apply(item);
            Assert.AreEqual("fizz", actual);
        }
        [TestMethod]
        public void TestBuzz()
        {
            int item = 5;
            Popper p = new Popper();
            string actual = p.apply(item);
            Assert.AreEqual("buzz", actual);
        }
        [TestMethod]
        public void TestFizzBuzz()
        {
            int item = 15;
            Popper p = new Popper();
            string actual = p.apply(item);
            Assert.AreEqual("fizzbuzz", actual);
        }

    }
}
