using Xunit;
using ProjektDrugi;
using System;
using System.Threading;
using FluentAssertions;

namespace Dodatkowe
{
    public class Tests
    {
        [Fact]
        public void TestWithTryCatch()
        {
            var stuff = new SomeLongRunningStuff();
            string message = string.Empty;
            try
            {
                stuff.MakeSomeWork();
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            Assert.Equal(message, "catch me if you can");
            
        }

        [Fact]
        public void Test()
        {
            var stuff = new SomeLongRunningStuff();
            var ex = Assert.Throws<Exception>(() => stuff.MakeSomeWork());
            Assert.Equal(ex.Message, "catch me if you can");
        }

        // Fluent Assertions - dodałem poniewarz chciałem sprawdzić czy ExecutionTime sprawdzi się lepiej niż [Fact(Timeout = 10000)]
        // Być może (a może nawet raczej) zależy to od dodatkowych metod/rzeczy wywoływanych przy teście, aczkolwiek ShouldNotExceed 
        // u mnie zadziałał lepiej. Timeout potrzebował znacznie więcej dodatkowych milisekund aby test przeszedł pomyślnie. 
        // Na pewno tworzenie obiektu Action pochłonęło tutaj trochę czasu, z czego już wynika że lepiej używać ExecutionTime.
        // Chyba że Timeout nie był robiony do celów czysto testowych - wtedy cała moja zabawa na marne.

        [Fact]
        public void TimeTestFluent()
        {
            Action action = () => Thread.Sleep(10000);
            action.ExecutionTime().ShouldNotExceed(10005.Milliseconds());
        }

        [Fact(Timeout = 10500)]
        public void TimeTest()
        {
            Action action = () => Thread.Sleep(10000);
            action();
        }
    }
}
