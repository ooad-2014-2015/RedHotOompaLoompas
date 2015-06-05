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
using ProjekatWPF.Models;
//MYSQL WORKBENCH
namespace ProjekatWPF
{
    /// <summary>
    /// Interaction logic for Selection.xaml
    /// </summary>
    public partial class Selection : Window
    {
        private LoginViewModel login;

        public Selection(LoginViewModel l)
        {
            InitializeComponent();
            login = l;
            DataContext = Login.S;
            InitializeComponent();
            login.S.CloseAction = new Action(() => this.Close());
            TextBlokac.Text = "Uspjesno ste prijavljeni kao: " + login.O.Ime + " " + login.O.Prezime;
        }

        public LoginViewModel Login
        {
            get { return login; }
            set { login = value; }
        }
    }
}
