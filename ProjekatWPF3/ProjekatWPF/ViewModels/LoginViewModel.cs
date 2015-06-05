using ProjekatWPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;


namespace ProjekatWPF
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string userA, passA;
        private bool validnaPrijava;
        public SqlConnection conn;
        public SqlDataReader r;
        public SqlCommand cmd;
        public bool test;
        private Korisnik o;
        string k;

        private SalonViewModel s;

        public Action helper { get; set; }
        public Action ClosePrijava { get; set; }
        public Action SubmitPrijava { get; set; }
        public Action ProfilInfo { get; set; }
        public Action CloseProfil { get; set; }
        public Action PokupiPodatke { get; set; }
        public Action PokupiLogin { get; set; }
        public Action uspjesnoLogovani { get; set; }
        public Action MessageBX { get; set; }

        public ICommand pokreniPrint { get; set; }
        public ICommand zatvoriProfil { get; set; }
        public ICommand prijaviSe { get; set; }
        public ICommand registrujSe { get; set; }
        public ICommand vidiPodatke { get; set; }
        public ICommand zatvoriPrijavu { get; set; }
        public ICommand potvrdiPrijavu { get; set; }
        public ICommand help { get; set; }

        public LoginViewModel()
        {
            s = new SalonViewModel(this);
            prijaviSe = new RelayCommand(p);
            registrujSe = new RelayCommand(reg);
            help = new RelayCommand(h);
            zatvoriPrijavu = new RelayCommand(c);
            potvrdiPrijavu = new RelayCommand(pp);
            vidiPodatke = new RelayCommand(vp);
            zatvoriProfil = new RelayCommand(zp);
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + Environment.CurrentDirectory.ToString() + @"\NANbaza.mdf;Integrated Security=True");
            cmd = new SqlCommand();
            pokreniPrint = new RelayCommand(ppp);
        }

        private void OnPropertyChanged(string p)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }

        private void ppp(object obj)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".pdf",
                Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
            };
            var fileOpenResult = openFileDialog.ShowDialog();
            if (fileOpenResult != true)
            {
                return;
            }

            var printDialog = new PrintDialog();
            printDialog.PageRangeSelection = PageRangeSelection.AllPages;
            printDialog.UserPageRangeEnabled = true;
            var doPrint = printDialog.ShowDialog();
            if (doPrint != true)
            {
                return;
            }
        }
        private void zp(object obj)
        {
            this.CloseProfil();
        }
        private void vp(object obj)
        {
            Profil p = new Profil(this);
            p.DataContext = this;
            p.Show();
        }
        private void pp(object obj)
        {
            SubmitPrijava();
            PokupiPodatke();
            try
            {
                cmd = new SqlCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into dbo.Registrovani ([ime], [prezime], [adresa], [telefon], [password], [email], [datumRodjenja]) values(@name, @surname, @address, @telephone, @password, @mail, @dr)";
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = O.Ime; 
                cmd.Parameters.Add("@surname", SqlDbType.VarChar);
                cmd.Parameters["@surname"].Value = O.Prezime;
                cmd.Parameters.Add("@address", SqlDbType.VarChar);
                cmd.Parameters["@address"].Value = O.Adresa; 
                cmd.Parameters.Add("@telephone", SqlDbType.VarChar);
                cmd.Parameters["@telephone"].Value = O.Mobitel;
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@password"].Value = O.Password; 
                cmd.Parameters.Add("@mail", SqlDbType.VarChar);
                cmd.Parameters["@mail"].Value = O.EMail; 
                cmd.Parameters.Add("@dr", SqlDbType.DateTime);
                cmd.Parameters["@dr"].Value = O.DatumRodjenja; 
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                K = e.Message;
                MessageBX();
            }
        }
        private void c(object obj)
        {
            ClosePrijava();
        }
        private void h(object obj)
        {
            helper();
        }
        private void reg(object obj)
        {
            SignUp f = new SignUp(this);
            f.DataContext = this;
            f.Show();
        }
        private void p(object obj)
        {
            PokupiLogin();
            cmd = new SqlCommand("SELECT * FROM [Registrovani] WHERE ime =@user AND password =@pass  ", conn);
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = userA;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = passA;
            uspjesnoLogovani();
            if (test == true)
            {
                Selection f = new Selection(this);
                f.DataContext = this.S;
                f.Show();
            }
        }
        public string Pass
        {
            get { return passA; }
            set { passA = value; OnPropertyChanged("passA"); }
        }
        public string User
        {
            get { return userA; }
            set { userA = value; OnPropertyChanged("userA"); }
        }
        public SalonViewModel S
        {
            get { return s; }
            set { s = value; }
        }
        public bool ValidnaPrijava
        {
            get { return validnaPrijava; }
            set { validnaPrijava = value; }
        }
        public Korisnik O
        {
            get { return o; }
            set { o = value; }
        }
        public string K
        {
            get { return k; }
            set { k = value; }
        }
    }
}
