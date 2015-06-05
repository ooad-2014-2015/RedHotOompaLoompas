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
    /// Interaction logic for Test_drive.xaml
    /// </summary>
    public partial class Test_drive : Window
    {
        SalonViewModel salon;
        public Test_drive(SalonViewModel s)
        {
           
            InitializeComponent();
            salon = s;
            salon.Testdrive.PreuzmiTekst = new Action(() => salon.Testdrive.varijablaZaTestnu = CBTD.SelectionBoxItem.ToString());
             salon.Testdrive.CloseAction = new Action(() => this.Close());

             salon.Testdrive.MB3 = new Action(() => MessageBox.Show("Molimo vas, popunite zahtjeve!", "Info"));
             DatePicker1.SelectedDate = DateTime.Now.Date;
        }

        private void ComboBoxTestDrive_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void SubmitTest_Click(object sender, RoutedEventArgs e)
        {
          
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
