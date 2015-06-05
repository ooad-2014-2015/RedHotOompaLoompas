using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatWPF
{
    public class Korisnik
    {
       
        private int _IDosobe;
        private string _Ime;
        private string _prezime;
        private string _mobitel;
        private string _eMail;
        private string _password;
        private string _adresa;
        private DateTime _datumRodjenja;

        public string Ime
        {
            get { return _Ime; }
            set { _Ime = value; }
        }
        public string Prezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }
        public int IDosobe
        {
            get { return _IDosobe; }
            set { _IDosobe = value; }
        }
        public string Mobitel
        {
            get { return _mobitel; }
            set { _mobitel = value; }
        }
        public string EMail
        {
            get { return _eMail; }
            set { _eMail = value; }
        }
        public string Adresa
        {
            get { return _adresa; }
            set { _adresa = value; }
        }
        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set { _datumRodjenja = value; }
        }  
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
