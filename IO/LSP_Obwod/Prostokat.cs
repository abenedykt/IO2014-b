using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Obwod
{
    public class Prostokat : Kwadrat
    {
        public int B { get; set; }
        public override int ObliczObwod()
        {
            return 2 * A + 2 * B;
        }

        public static Prostokat operator +(Prostokat A, Prostokat B)
        {
            return new Prostokat
            {
                A = A.A + B.A,
                B = A.B + B.B
            };
        }
    }
}
