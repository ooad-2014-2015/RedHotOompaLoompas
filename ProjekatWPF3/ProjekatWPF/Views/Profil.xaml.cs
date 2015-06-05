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
    /// Interaction logic for Profil.xaml
    /// </summary>
    public partial class Profil : Window
    {
        private LoginViewModel l;

        public Profil(LoginViewModel lo)
        {
            InitializeComponent();
            l = lo;
            l.CloseProfil = new Action(() => this.Close());
            popuniPolja();
        }

        void popuniPolja()
        {
            Ti.Text = l.O.Ime;
            Ti.IsEnabled = false;
            Tp.Text = l.O.Prezime;
            Tp.IsEnabled = false;
            Ta.Text = l.O.Adresa;
            Ta.IsEnabled = false;
            Tp1.Text = l.O.Password;
            Tp1.IsEnabled = false;
            Tt.Text = l.O.Mobitel;
            Tt.IsEnabled = false;
            Te.Text = l.O.EMail;
            Te.IsEnabled = false;
            Tr.Text = l.O.DatumRodjenja.ToString();
            Tr.IsEnabled = false;
        }

        public LoginViewModel L
        {
            get { return l; }
            set { l = value; }
        }
    }
}
