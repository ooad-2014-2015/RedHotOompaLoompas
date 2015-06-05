using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatWPF
{
    class Transakcija
    {
        private enum Usluga { Kupovina, ProbnaVoznja, Servisiranje };
        private enum NacinPlacanja { Gotovinom, Karticom };
        private int _IDTransakcije;
        private Usluga _tipUsluge;
        private NacinPlacanja _nacinPlacanja;

        public Transakcija() { }

        public int IDTransakcije
        {
            get { return _IDTransakcije; }
            set { _IDTransakcije = value; }
        }
        private Usluga TipUsluge
        {
            get { return _tipUsluge; }
            set { _tipUsluge = value; }
        }
        private NacinPlacanja NacinPlacanja1
        {
            get { return _nacinPlacanja; }
            set { _nacinPlacanja = value; }
        }
    }
}
