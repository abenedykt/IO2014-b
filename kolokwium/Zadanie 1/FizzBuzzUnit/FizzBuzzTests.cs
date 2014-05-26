using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzGame;
using Xunit;

namespace FizzBuzzUnit
{
    public class FizzBuzzTests
    {
        [Fact]
        public void TestFizzFor3()
        {
            FizzBuzz FB = new FizzBuzz();
            string result = FB.Solve(3);
            Assert.Equal(result, "Fizz");
        }
        [Fact]
        public void TestFizzFor12()
        {
            FizzBuzz FB = new FizzBuzz();
            string result = FB.Solve(12);
            Assert.Equal(result, "Fizz");
        }
        [Fact]
        public void TestBuzzFor5()
        {
            FizzBuzz FB = new FizzBuzz();
            string result = FB.Solve(5);
            Assert.Equal(result, "Buzz");
        }
        [Fact]
        public void TestFizzBuzzFor15()
        {
            FizzBuzz FB = new FizzBuzz();
            string result = FB.Solve(15);
            Assert.Equal(result, "FizzBuzz");
        }
        [Fact]
        public void Test11For11()
        {
            FizzBuzz FB = new FizzBuzz();
            string result = FB.Solve(11);
            Assert.Equal(result, "11");
        }
    }
}
