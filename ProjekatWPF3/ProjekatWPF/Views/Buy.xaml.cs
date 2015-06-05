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
    /// Interaction logic for Buy.xaml
    /// </summary>
    public partial class Buy : Window
    {
        private SalonViewModel salon;

        public Buy(SalonViewModel s)
        {
            InitializeComponent();
            salon = s;
            salon.Kupovina.MB3 = new Action(() => MessageBox.Show("Molimo vas, popunite zahtjeve!", "Info"));
            salon.Kupovina.PreuzmiTekst = new Action(() => salon.Kupovina.varijablaZaTestnu = CB2.SelectionBoxItem.ToString());
            salon.Kupovina.PreuzmiTekst1 = new Action(() => salon.Kupovina.varijablaZaTestnu1 = ComboBox2.SelectionBoxItem.ToString());
            salon.Kupovina.CloseAction = new Action(() => this.Close());
            salon.Kupovina.Popuni = new Action(() => UpisiUtekstBox());
            UpisiUtekstBox();
            //PopuniComboBox();
        }
        
        private void windowsFormsHost1_LayoutError(object sender, System.Windows.Forms.Integration.LayoutExceptionEventArgs e)
        {
            e.ThrowException = false;
        }

        public void UpisiUtekstBox()
        {
            string put = Environment.CurrentDirectory;
            System.Windows.Forms.PictureBox picturebox1 = new System.Windows.Forms.PictureBox();
            windowsFormsHost1.Child = picturebox1;
            if (ComboBox2.Text == "Series1 Coupe")
            {
                List<Automobil> aa = Salon.Kupovina.Automobili;
                TB1.Text = Salon.Kupovina.Automobili[0].Gorivo;
                TB2.Text = Salon.Kupovina.Automobili[0].GodinaProizvodnje;
                TB3.Text = Salon.Kupovina.Automobili[0].Cijena;
                TB4.Text = Salon.Kupovina.Automobili[0].Tezina;
                TB5.Text = Salon.Kupovina.Automobili[0].MaksimalnaTezina;
                TB6.Text = Salon.Kupovina.Automobili[0].KonjskihSnaga;
                TB7.Text = Salon.Kupovina.Automobili[0].Kubikaza;
                TB8.Text = Salon.Kupovina.Automobili[0].BrojVrata;
                TB9.Text = Salon.Kupovina.Automobili[0].IDauta.ToString();
                string s = @"" + put + "/" + "1CoupeBlack.png";
                if (bjeli.IsChecked == true)
                {
                    s = @"" + put + "/" + "1CoupeWhite.png";
                }
                picturebox1.ImageLocation = s;
                picturebox1.Location = new System.Drawing.Point(50, 0);
            }
            else if (ComboBox2.Text == "Series1 Cabrio")
            {
                TB1.Text = Salon.Kupovina.Automobili[1].Gorivo;
                TB2.Text = Salon.Kupovina.Automobili[1].GodinaProizvodnje;
                TB3.Text = Salon.Kupovina.Automobili[1].Cijena;
                TB4.Text = Salon.Kupovina.Automobili[1].Tezina;
                TB5.Text = Salon.Kupovina.Automobili[1].MaksimalnaTezina;
                TB6.Text = Salon.Kupovina.Automobili[1].KonjskihSnaga;
                TB7.Text = Salon.Kupovina.Automobili[1].Kubikaza;
                TB8.Text = Salon.Kupovina.Automobili[1].BrojVrata;
                TB9.Text = Salon.Kupovina.Automobili[1].IDauta.ToString();
                string s = @"" + put + "/" + "1CabrioBlack.png";
                if (bjeli.IsChecked == true)
                {
                    s = @"" + put + "/" + "1CabrioWhite.png";
                }
                picturebox1.ImageLocation = s;
                picturebox1.Location = new System.Drawing.Point(0, 0);
            }
            else if (ComboBox2.Text == "Series2 ActiveTourer")
            {
                TB1.Text = Salon.Kupovina.Automobili[2].Gorivo;
                TB2.Text = Salon.Kupovina.Automobili[2].GodinaProizvodnje;
                TB3.Text = Salon.Kupovina.Automobili[2].Cijena;
                TB4.Text = Salon.Kupovina.Automobili[2].Tezina;
                TB5.Text = Salon.Kupovina.Automobili[2].MaksimalnaTezina;
                TB6.Text = Salon.Kupovina.Automobili[2].KonjskihSnaga;
                TB7.Text = Salon.Kupovina.Automobili[2].Kubikaza;
                TB8.Text = Salon.Kupovina.Automobili[2].BrojVrata;
                TB9.Text = Salon.Kupovina.Automobili[2].IDauta.ToString();
                string s = @"" + put + "/" + "2ActiveTourerBlack.png";
                if (bjeli.IsChecked == true)
                {
                    s = @"" + put + "/" + "2ActiveTourerWhite.png";
                }
                picturebox1.ImageLocation = s;
                picturebox1.Location = new System.Drawing.Point(100, 0);
            }
            else if (ComboBox2.Text == "Series4 Coupe")
            {
                TB1.Text = Salon.Kupovina.Automobili[3].Gorivo;
                TB2.Text = Salon.Kupovina.Automobili[3].GodinaProizvodnje;
                TB3.Text = Salon.Kupovina.Automobili[3].Cijena;
                TB4.Text = Salon.Kupovina.Automobili[3].Tezina;
                TB5.Text = Salon.Kupovina.Automobili[3].MaksimalnaTezina;
                TB6.Text = Salon.Kupovina.Automobili[3].KonjskihSnaga;
                TB7.Text = Salon.Kupovina.Automobili[3].Kubikaza;
                TB8.Text = Salon.Kupovina.Automobili[3].BrojVrata;
                TB9.Text = Salon.Kupovina.Automobili[3].IDauta.ToString();
                string s = @"" + put + "/" + "4CoupeBlack.png";
                if (bjeli.IsChecked == true)
                {
                    s = @"" + put + "/" + "4CoupeWhite.png";
                }
                picturebox1.ImageLocation = s;
                picturebox1.Location = new System.Drawing.Point(65, 20);
            }
            else if (ComboBox2.Text == "SeriesX X1")
            {
                TB1.Text = Salon.Kupovina.Automobili[4].Gorivo;
                TB2.Text = Salon.Kupovina.Automobili[4].GodinaProizvodnje;
                TB3.Text = Salon.Kupovina.Automobili[4].Cijena;
                TB4.Text = Salon.Kupovina.Automobili[4].Tezina;
                TB5.Text = Salon.Kupovina.Automobili[4].MaksimalnaTezina;
                TB6.Text = Salon.Kupovina.Automobili[4].KonjskihSnaga;
                TB7.Text = Salon.Kupovina.Automobili[4].Kubikaza;
                TB8.Text = Salon.Kupovina.Automobili[4].BrojVrata;
                TB9.Text = Salon.Kupovina.Automobili[4].IDauta.ToString();
                string s = @"" + put + "/" + "X1Black.png";
                if (bjeli.IsChecked == true)
                {
                    s = @"" + put + "/" + "X1White.png";
                }
                picturebox1.ImageLocation = s;
                picturebox1.Location = new System.Drawing.Point(70, 40);
            }
            else if (ComboBox2.Text == "SeriesX X3")
            {
                TB1.Text = Salon.Kupovina.Automobili[5].Gorivo;
                TB2.Text = Salon.Kupovina.Automobili[5].GodinaProizvodnje;
                TB3.Text = Salon.Kupovina.Automobili[5].Cijena;
                TB4.Text = Salon.Kupovina.Automobili[5].Tezina;
                TB5.Text = Salon.Kupovina.Automobili[5].MaksimalnaTezina;
                TB6.Text = Salon.Kupovina.Automobili[5].KonjskihSnaga;
                TB7.Text = Salon.Kupovina.Automobili[5].Kubikaza;
                TB8.Text = Salon.Kupovina.Automobili[5].BrojVrata;
                TB9.Text = Salon.Kupovina.Automobili[5].IDauta.ToString();
                string s = @"" + put + "/" + "X3.png";
                if (bjeli.IsChecked == true)
                {
                    s = @"" + put + "/" + "X3.png";
                }
                picturebox1.ImageLocation = s;
                picturebox1.Location = new System.Drawing.Point(60, 20);
            }
            else if (ComboBox2.Text == "SeriesX X5")
            {
                TB1.Text = Salon.Kupovina.Automobili[6].Gorivo;
                TB2.Text = Salon.Kupovina.Automobili[6].GodinaProizvodnje;
                TB3.Text = Salon.Kupovina.Automobili[6].Cijena;
                TB4.Text = Salon.Kupovina.Automobili[6].Tezina;
                TB5.Text = Salon.Kupovina.Automobili[6].MaksimalnaTezina;
                TB6.Text = Salon.Kupovina.Automobili[6].KonjskihSnaga;
                TB7.Text = Salon.Kupovina.Automobili[6].Kubikaza;
                TB8.Text = Salon.Kupovina.Automobili[6].BrojVrata;
                TB9.Text = Salon.Kupovina.Automobili[6].IDauta.ToString();
                string s = @"" + put + "/" + "X5Black.png";
                if (bjeli.IsChecked == true)
                {
                    s = @"" + put + "/" + "X5White.png";
                }
                picturebox1.ImageLocation = s;
                picturebox1.Location = new System.Drawing.Point(80, 40);
            }
            else if (ComboBox2.Text == "SeriesX X6")
            {
                TB1.Text = Salon.Kupovina.Automobili[7].Gorivo;
                TB2.Text = Salon.Kupovina.Automobili[7].GodinaProizvodnje;
                TB3.Text = Salon.Kupovina.Automobili[7].Cijena;
                TB4.Text = Salon.Kupovina.Automobili[7].Tezina;
                TB5.Text = Salon.Kupovina.Automobili[7].MaksimalnaTezina;
                TB6.Text = Salon.Kupovina.Automobili[7].KonjskihSnaga;
                TB7.Text = Salon.Kupovina.Automobili[7].Kubikaza;
                TB8.Text = Salon.Kupovina.Automobili[7].BrojVrata;
                TB9.Text = Salon.Kupovina.Automobili[7].IDauta.ToString();
                string s = @"" + put + "/" + "X6Black.png";
                if (bjeli.IsChecked == true)
                {
                    s = @"" + put + "/" + "X6White.png";
                }
                picturebox1.ImageLocation = s;
                picturebox1.Location = new System.Drawing.Point(85, 40);
            }

            else if (ComboBox2.Text == "Series7 Limousine")
            {
                TB1.Text = Salon.Kupovina.Automobili[8].Gorivo;
                TB2.Text = Salon.Kupovina.Automobili[8].GodinaProizvodnje;
                TB3.Text = Salon.Kupovina.Automobili[8].Cijena;
                TB4.Text = Salon.Kupovina.Automobili[8].Tezina;
                TB5.Text = Salon.Kupovina.Automobili[8].MaksimalnaTezina;
                TB6.Text = Salon.Kupovina.Automobili[8].KonjskihSnaga;
                TB7.Text = Salon.Kupovina.Automobili[8].Kubikaza;
                TB8.Text = Salon.Kupovina.Automobili[8].BrojVrata;
                TB9.Text = Salon.Kupovina.Automobili[8].IDauta.ToString();
                string s = @"" + put + "/" + "7LimousineBlack.png";
                if (bjeli.IsChecked == true)
                {
                    s = @"" + put + "/" + "7LimousineWhite.png";
                }
                picturebox1.ImageLocation = s;
                picturebox1.Location = new System.Drawing.Point(65, 45);
            }
            else if (ComboBox2.Text == "SeriesZ4 Roadster")
            {
                TB1.Text = Salon.Kupovina.Automobili[9].Gorivo;
                TB2.Text = Salon.Kupovina.Automobili[9].GodinaProizvodnje;
                TB3.Text = Salon.Kupovina.Automobili[9].Cijena;
                TB4.Text = Salon.Kupovina.Automobili[9].Tezina;
                TB5.Text = Salon.Kupovina.Automobili[9].MaksimalnaTezina;
                TB6.Text = Salon.Kupovina.Automobili[9].KonjskihSnaga;
                TB7.Text = Salon.Kupovina.Automobili[9].Kubikaza;
                TB8.Text = Salon.Kupovina.Automobili[9].BrojVrata;
                TB9.Text = Salon.Kupovina.Automobili[9].IDauta.ToString();
                string s = @"" + put + "/" + "Z4RoadsterBlack.png";
                if (bjeli.IsChecked == true)
                {
                    s = @"" + put + "/" + "Z4RoadsterWhite.png";
                }
                picturebox1.ImageLocation = s;
                picturebox1.Location = new System.Drawing.Point(80, 45);
            }
            else
            {
                TB1.Text = "";
                TB2.Text = "";
                TB3.Text = "";
                TB4.Text = "";
                TB5.Text = "";
                TB6.Text = "";
                TB7.Text = "";
                TB8.Text = "";
                TB9.Text = "";
                string s = @"" + put + "/" + "BMW_logo3.png";
                picturebox1.ImageLocation = s;
                picturebox1.Location = new System.Drawing.Point(200, 0);
            }
            if (CB2.Text == "Credit Card")
            {
                cardNumberLabel.Visibility--;
                cardNumberTextBox.Visibility--;
                cardNumberLabel.IsEnabled = true;
                cardNumberTextBox.IsEnabled = true;
            }
            else if (CB2.Text == "Cash")
            {
                cardNumberLabel.Visibility++;
                cardNumberTextBox.Visibility++;
                cardNumberLabel.IsEnabled = false;
                cardNumberTextBox.IsEnabled = false;

            }
        }

        public SalonViewModel Salon
        {
            get { return salon; }
            set { salon = value; }
        }

    }
}
