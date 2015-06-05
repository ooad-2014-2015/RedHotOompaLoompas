using ProjekatWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjekatWPF
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>

    public partial class SignUp : Window
    {
        LoginViewModel login;

        public SignUp(LoginViewModel s)
        {
            InitializeComponent();
            login = s;
            login.MessageBX = new Action(() => MessageBox.Show(login.K));
            login.ClosePrijava = new Action(() => this.Close());
            login.SubmitPrijava = new Action(() => prijavaLogika());
            login.PokupiPodatke = new Action(() => pokupiPodatke());
        }
        
        public LoginViewModel Login
        {
            get { return login; }
            set { login = value; }
        }

        void pokupiPodatke()
        {
            login.O = new Korisnik();
            login.O.Ime = SUime.Text;
            login.O.Prezime = SUprezime.Text;
            login.O.Mobitel = SUmob.Text;
            login.O.EMail = SUmail.Text;
            login.O.Adresa = SUaddress.Text;
            login.O.DatumRodjenja = SUdatum.SelectedDate.Value;
            login.O.Password = SUpass.Text;
        }

        void prijavaLogika(){
        if (SUaddress.Text == "" || SUdatum.SelectedDate == null || SUime.Text == "" || SUmail.Text == "" || SUmob.Text == "" || SUpass.Text == "" || SUprezime.Text == "")
        {
            Login.ValidnaPrijava = true;
            MessageBox.Show("Niste popunili sva polja!", "INFO");
        }
        else
        {
            MessageBox.Show("Uspjesno kreiran korisnik!", "INFO");
            this.Close();
        }
        }
    }
}
