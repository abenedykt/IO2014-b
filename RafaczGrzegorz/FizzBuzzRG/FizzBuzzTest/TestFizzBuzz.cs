using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzRG;
using Xunit;

namespace FizzBuzzTest
{
  public  class TestFizzBuzz
    {
      [Fact]
      public void FizzBuzzT()
      {
          FizzBuzz fizzBuzz = new FizzBuzz();
          Assert.Equal("FizzBuzz", fizzBuzz.getFizzBuzz(15));
      }
[Fact]  
      public void FizzT()
      {
          FizzBuzz fizz= new FizzBuzz();
          Assert.Equal("Fizz",fizz.getFizzBuzz(5));

      }
      [Fact]
      public void BuzzT()
      {
          FizzBuzz buzz = new FizzBuzz();
          Assert.Equal("Buzz",buzz.getFizzBuzz(3));
      }
      [Fact]
      public void Numer()
      {
          FizzBuzz fb=new FizzBuzz();
          Assert.Equal("2",fb.getFizzBuzz(2));
      }

    }
}
