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
    /// Interaction logic for Order_new_key.xaml
    /// </summary>
    public partial class Order_new_key : Window
    {
        SalonViewModel salon;
        public Order_new_key(SalonViewModel s)
        {
            InitializeComponent();
            salon = s;
            
               salon.Kljuc.ProvjeriCombo = new Action(() => salon.Kljuc.varijabla =CBONK.SelectionBoxItem.ToString());

            //salon.Kljuc.ProvjeriCombo = new Action(() => MessageBox.Show("Morate izabrati model", "Info")));
            
           
            salon.Kljuc.MB = new Action(() => MessageBox.Show("Uspjesna kupovina!","Info"));
            salon.Kljuc.MB2 = new Action(() => MessageBox.Show("Molimo vas, odaberite model!", "Info"));

            salon.Kljuc.CloseAction = new Action(() => this.Close());
            
            }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
           
            
        }

        private void CBHomedelivery_GotFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void CBHomedelivery_Click(object sender, RoutedEventArgs e)
        {
            if (CBHomedelivery.IsChecked == true)
            {

            }
            else if (CBHomedelivery.IsChecked == false)
            {

              

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void CBONK_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
