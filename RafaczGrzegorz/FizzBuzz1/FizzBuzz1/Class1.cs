using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz1
{
    public class Class1
    {
        [Fact]
        public void Dla3()
        {
            var game = new Game();
                var r = game.Say(3);
                 Assert.Equal("Fizz", r);
           
        }
         [Fact]
        public void Dla5()
        {
            var game = new Game();
            var r = game.Say(5);
            Assert.Equal("Buzz", r);
        }
         [Fact]
         public void Dla15()
         {
             var game = new Game();
             var r = game.Say(15);
             Assert.Equal("FizzBuzz", r);
         }
        [Fact]
         public void DlaMaxInt() { var game = new Game(); 
            var r = game.Say(int.MaxValue);
            Assert.Equal("", r); 
        }
        
    }
}
