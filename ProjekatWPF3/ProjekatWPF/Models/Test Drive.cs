using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatWPF
{
    class Test_Drive
    {
        private string model;
        private DateTime date;
        private Korisnik korisnik;
        private bool SaRadnikom;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Korisnik Korisnik
        {
            get { return korisnik; }
            set { korisnik = value; }
        }
        public bool SaRadnikom1
        {
            get { return SaRadnikom; }
            set { SaRadnikom = value; }
        }

    }
}
