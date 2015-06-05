using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatWPF
{
    public class Kupovina
    {
        private int _IDKupovina;
        private DateTime _datumKupovine;
        private double _cijena;
        private List<int> _IDmodela;
        private int _IDKupca;

        public Kupovina()
        {
        }

        public void izvrsiTransakciju()
        {
        }

        public void dajPodatkeOkupcu()
        {
        }

        public int IDKupovina
        {
            get { return _IDKupovina; }
            set { _IDKupovina = value; }
        }
        public DateTime DatumKupovine
        {
            get { return _datumKupovine; }
            set { _datumKupovine = value; }
        }
        public double Cijena
        {
            get { return _cijena; }
            set { _cijena = value; }
        }
        public List<int> IDmodela
        {
            get { return _IDmodela; }
            set { _IDmodela = value; }
        }
        public int IDKupca
        {
            get { return _IDKupca; }
            set { _IDKupca = value; }
        }     
    }
}
