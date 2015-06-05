using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatWPF
{
    public class Automobil
    {
        private int _IDauta;
        private string _model;
        private string _gorivo;
        private string _godinaProizvodnje;
        private string _cijena;
        private string _kubikaza;
        private string _tezina;
        private string _maksimalnaTezina;
        private string _konjskihSnaga;
        private string _brojVrata;
        private string _boja;

        public Automobil(int iDauta, string model, string gorivo, string godinaProizvodnje,
                 string cijena, string kubikaza, string tezina, string maksimalnaTezina,
                 string konjskihSnaga, string brojVrata)
        {
            IDauta = iDauta;
            Model = model;
            Gorivo = gorivo;
            GodinaProizvodnje = godinaProizvodnje;
            Cijena = cijena;
            Kubikaza = kubikaza;
            Tezina = tezina;
            MaksimalnaTezina = maksimalnaTezina;
            KonjskihSnaga = konjskihSnaga;
            BrojVrata = brojVrata;
        }

        public int IDauta
        {
            get { return _IDauta; }
            set { _IDauta = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Gorivo
        {
            get { return _gorivo; }
            set { _gorivo = value; }
        }
        public string GodinaProizvodnje
        {
            get { return _godinaProizvodnje; }
            set { _godinaProizvodnje = value; }
        }
        public string Cijena
        {
            get { return _cijena; }
            set { _cijena = value; }
        }
        public string Kubikaza
        {
            get { return _kubikaza; }
            set { _kubikaza = value; }
        }
        public string Tezina
        {
            get { return _tezina; }
            set { _tezina = value; }
        }    
        public string MaksimalnaTezina
        {
            get { return _maksimalnaTezina; }
            set { _maksimalnaTezina = value; }
        }
        public string KonjskihSnaga
        {
            get { return _konjskihSnaga; }
            set { _konjskihSnaga = value; }
        }
        public string BrojVrata
        {
            get { return _brojVrata; }
            set { _brojVrata = value; }
        }
        public string Boja
        {
            get { return _boja; }
            set { _boja = value; }
        }
    }
}
