using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Obwod
{
    public class Kwadrat : Figura
    {
        public int A { get; set; }
        public override int ObliczObwod()
        {
            return 4*A;
        }
    }
}
