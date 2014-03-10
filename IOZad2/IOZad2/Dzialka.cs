using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOZad2
{
    public class Dzialka
    {
        #region public property
        public Punkt Srodek { get; set; }

        private List<Punkt> _Wierzcholki;
        public List<Punkt> Wierzcholki
        {
            get
            {
                if (_Wierzcholki == null) _Wierzcholki = new List<Punkt>();
                return _Wierzcholki;
            }
            set { _Wierzcholki = new List<Punkt>(value); }
        }
        #endregion

        #region public method
        public void DodajPunkt(Punkt punkt)
        {
            Wierzcholki.Add(punkt);
        }

        public void UsunPunkt(Punkt punkt)
        {
            _Wierzcholki.Remove(punkt);
        }
        #endregion
    }
}
