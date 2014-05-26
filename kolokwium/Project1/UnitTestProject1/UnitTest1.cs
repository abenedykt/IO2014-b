using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Numeric0Test()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.AreEqual("0", a.GetValue(0));
        }

        [TestMethod]
        public void FizzBuzzTest()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.AreEqual("FizzBuzz", a.GetValue(15));
        }

        [TestMethod]
        public void FizzTest()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.AreEqual("Fizz", a.GetValue(3));
        }

        [TestMethod]
        public void BuzzTest()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.AreEqual("Buzz", a.GetValue(5));
        }

        [TestMethod]
        public void Numeric7Test()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.AreEqual("7", a.GetValue(7));
        }

        [TestMethod]
        public void Numeric11Test()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.AreEqual("11", a.GetValue(11));
        }

        [TestMethod]
        public void Numeric21Test()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.AreEqual("Fizz", a.GetValue(21));
        }
    }
}
