using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NDepend1;

namespace NDepend2
{
    public class Program : INew
    {
        static void Main()
        {
            var c = new C();
            c.Createnew();
        }

        interface IA
        {
        }

        public abstract class B : IA
        {
            public abstract void Createnew();

        }

        public class C : B
        {
            public override void Createnew()
            {
            }
        }
        public abstract class A
        {
        }

        public void Blablasdf()
        {
            throw new NotImplementedException();
        }
    }
}
