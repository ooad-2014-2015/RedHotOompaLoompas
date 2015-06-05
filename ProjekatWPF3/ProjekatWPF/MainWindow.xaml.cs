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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProjekatWPF.ViewModels;
using ProjekatWPF.Models;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace ProjekatWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoginViewModel login;
        public SqlConnection conn;

        public MainWindow()
        {
            InitializeComponent();
            pokreniSliku();
            login = new LoginViewModel();
            Login.helper = new Action(() => pomoc());
            Login.PokupiLogin = new Action(() => pokupiUserIPW());
            Login.uspjesnoLogovani = new Action(() => logovanje());
            upisiAuta();
            DataContext = login;
            Thread tid1 = new Thread(new ThreadStart(Thread1));
            Thread tid2 = new Thread(new ThreadStart(Thread2));
            tid1.Start();
            tid2.Start();
        }

        void upisiAuta()
        {
            try
            {
                Login.S.Kupovina.conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + Environment.CurrentDirectory.ToString() + @"\NANbaza.mdf;Integrated Security=True");
                Login.S.Kupovina.cmd = new SqlCommand("SELECT * FROM Automobili", Login.S.Kupovina.conn);
                Login.S.Kupovina.conn.Open();
                Login.S.Kupovina.r = Login.S.Kupovina.cmd.ExecuteReader();
                while (Login.S.Kupovina.r.Read())
                {
                    Automobil a = new Automobil(Convert.ToInt32(Login.S.Kupovina.r[0].ToString()), Login.S.Kupovina.r[9].ToString(), Login.S.Kupovina.r[1].ToString(), Login.S.Kupovina.r[2].ToString(), Login.S.Kupovina.r[3].ToString(), Login.S.Kupovina.r[7].ToString(), Login.S.Kupovina.r[4].ToString(), Login.S.Kupovina.r[5].ToString(), Login.S.Kupovina.r[6].ToString(), Login.S.Kupovina.r[8].ToString());
                    Login.S.Kupovina.Automobili.Add(a);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Login.S.Kupovina.conn.Close();
            }
        }

        void logovanje()
        {
            try
            {
                if (B1.Text == "" || TB2.Password == "") throw new Exception("Polje ne smije biti prazno");
                Login.conn.Open();
                Login.r = Login.cmd.ExecuteReader();
                if (Login.r.Read() == false) throw new Exception("Nije tacan username ili password!");
                MessageBox.Show("Uspjesno logovani!");
                Login.O = new Korisnik();
                login.O.IDosobe = Convert.ToInt32(Login.r["Id"].ToString());
                login.O.Ime = Login.r["ime"].ToString();
                login.O.Prezime = Login.r["prezime"].ToString();
                login.O.Mobitel = Login.r["telefon"].ToString();
                login.O.EMail = Login.r["email"].ToString();
                login.O.Adresa = Login.r["adresa"].ToString();
                login.O.DatumRodjenja = Convert.ToDateTime(Login.r["datumRodjenja"]);
                login.O.Password = Login.r["password"].ToString();
                Login.test = true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                Login.test = false;
            }
            finally
            {
                Login.conn.Close();
            }
        }

        void pokupiUserIPW()
        {
            Login.User = B1.Text;
            Login.Pass = TB2.Password;
        }

        void pokreniSliku()
        {
            string put = Environment.CurrentDirectory;
            System.Windows.Forms.PictureBox picturebox1 = new System.Windows.Forms.PictureBox();
            WFHmain.Child = picturebox1;
            picturebox1.ImageLocation = @"" + put + "/" + "BMW_logoMAIN.png";
            picturebox1.Location = new System.Drawing.Point(0, 0);
        }

        void pomoc()
        {
            string put = Environment.CurrentDirectory;
            Process.Start(@"" + put + "/" + "Help.docx");
        }

        public void Thread1()
        {
            try
            {
                while (1 == 1)
                {
                    welcome.Dispatcher.Invoke(new Action(() => welcome.Foreground = new SolidColorBrush(Colors.Blue))); Thread.Sleep(1000);
                    welcome.Dispatcher.Invoke(new Action(() => welcome.Foreground = new SolidColorBrush(Colors.Gray))); Thread.Sleep(1000);
                    welcome.Dispatcher.Invoke(new Action(() => welcome.Foreground = new SolidColorBrush(Colors.Black))); Thread.Sleep(1000); 
                }
            }
            catch (Exception e)
            {
                string s = e.Message.ToString();
            }
        }

        public void Thread2()
        {
            Thread.Sleep(1);
            try
            {
                while (1 == 1)
                {
                    Thread.Sleep(1000); welcome.Dispatcher.Invoke(new Action(() => welcome.RenderTransform = new TranslateTransform { X = 0, Y = 0 }));
                    Thread.Sleep(1000); welcome.Dispatcher.Invoke(new Action(() => welcome.RenderTransform = new TranslateTransform { X = 10,Y = 0} ));
                    Thread.Sleep(1000); welcome.Dispatcher.Invoke(new Action(() => welcome.RenderTransform = new TranslateTransform { X = 20, Y = 0 }));
                }
            }
            catch (Exception e)
            {
                string s = e.Message.ToString();
            }
        }

        public LoginViewModel Login
        {
            get { return login; }
            set { login = value; }
        }
    }
}
