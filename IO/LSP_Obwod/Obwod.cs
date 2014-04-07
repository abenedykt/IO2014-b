using Xunit;

namespace LSP_Obwod
{
    public class Obwod
    {
        [Fact]
        public void TestObliczObwodProstokat()
        {
            var prostokat = new Prostokat {A = 5, B = 5};
            Assert.Equal(prostokat.ObliczObwod(), 20);
        }
        [Fact]
        public void TestObliczObwodKwadrat()
        {
            var prostokat = new Kwadrat() { A = 5 };
            Assert.Equal(prostokat.ObliczObwod(), 20);
        }
    }
}
