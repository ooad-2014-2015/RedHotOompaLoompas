using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatWPF
{
    public class KupovinaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand zatvoriKupovinu { get; set; }
        public ICommand popuni { get; set; }

        public SqlConnection conn;
        public SqlDataReader r;
        public SqlCommand cmd;
        public List<Automobil> automobili;
        public string varijablaZaTestnu { get; set; }
        public string varijablaZaTestnu1 { get; set; }

        public Action Popuni { get; set; }
        public Action MB3 { get; set; }
        public Action PreuzmiTekst { get; set; }
        public Action PreuzmiTekst1 { get; set; }
        public Action CloseAction { get; set; }
        public Action ProvjeriButton { get; set; }
        public Action PokupiAuta { get; set; }

        public KupovinaViewModel()
        {
            zatvoriKupovinu = new RelayCommand(z);
            popuni = new RelayCommand(p);
            automobili = new List<Automobil>();
        }

        private void z(object obj)
        {
            PreuzmiTekst();
            if (varijablaZaTestnu == "" || varijablaZaTestnu1=="") MB3();
            else CloseAction();  
        }

        private void p(object obj)
        {
            Popuni();
        }
    
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public List<Automobil> Automobili
        {
            get { return automobili; }
            set { automobili = value; OnPropertyChanged("automobili"); }
        }
    }
}
