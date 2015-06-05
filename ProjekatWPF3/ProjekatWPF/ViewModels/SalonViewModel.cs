using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatWPF.Models;
using System.Windows.Input;
using ProjekatWPF.ViewModels;
using System.Data.SqlClient;
using System.Data;

namespace ProjekatWPF.Models
{
    public class SalonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private LoginViewModel l;
        private KupovinaViewModel kupovina;
        private OrderNewKeyView kljuc;
        private RezervacijaViewModel rezervacija;
        private TestDriveViewModel testdrive;

        public Action CloseAction { get; set; }

        public ICommand zatvoriSelekciju { get; set; }
        public ICommand prijaviSe { get; set; }
        public ICommand otvoriKupovinu { get; set; }
        public ICommand otvoriKljuc { get; set; }
        public ICommand otvoriRezervaciju { get; set; }
        public ICommand otvoriTestnuVoznju{ get; set; }

        public SalonViewModel(LoginViewModel lo)
        {
            l = lo;
            zatvoriSelekciju = new RelayCommand(zatvori);       
            otvoriKupovinu = new RelayCommand(k);
            otvoriKljuc = new RelayCommand(ok);
            otvoriRezervaciju = new RelayCommand(m);
            otvoriTestnuVoznju = new RelayCommand(n);
            kupovina = new KupovinaViewModel();
            kljuc = new OrderNewKeyView();
            rezervacija = new RezervacijaViewModel();
            testdrive = new TestDriveViewModel();
        }

        private void zatvori(object obj)
        {
            this.CloseAction();
        }

        private void ok(object obj)
        {

            Order_new_key t = new Order_new_key(this);
            t.DataContext = this.Kljuc;
            t.Show();          
        }

        private void n(object obj)
        {
            Test_drive t = new Test_drive(this);
            t.DataContext = this.testdrive;
            t.Show();        
        }

        private void m(object obj)
        {
            Service_appointment s = new Service_appointment(this);
            s.DataContext = this.Rezervacija;
            s.Show();
          }

        private void k(object obj)
        {
            Buy b = new Buy(this);
            b.DataContext = this.kupovina;
            b.Show();

        }

        private void OnPropertyChanged(string p)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }

        public RezervacijaViewModel Rezervacija
        {
            get { return rezervacija; }
            set { rezervacija = value; OnPropertyChanged("rezervacija"); }
        }
        public OrderNewKeyView Kljuc
        {
            get { return kljuc; }
            set { kljuc = value; OnPropertyChanged("kljuc"); }
        }
        public TestDriveViewModel Testdrive
        {
            get { return testdrive; }
            set { testdrive = value; OnPropertyChanged("testdrive"); }
        }
        public KupovinaViewModel Kupovina
        {
            get { return kupovina; }
            set { kupovina = value; OnPropertyChanged("kupovina"); }
        }
        public LoginViewModel L
        {
            get { return l; }
            set { l = value; OnPropertyChanged("l"); }
        }
    }
}
