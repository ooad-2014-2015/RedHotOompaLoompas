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
    /// Interaction logic for Service_appointment.xaml
    /// </summary>
    public partial class Service_appointment : Window
    {
        SalonViewModel salon;
        public Service_appointment(SalonViewModel s)
        {
            
       
            InitializeComponent();
            salon = s;
            salon.Rezervacija.CloseAction = new Action(() => this.Close());
            salon.Rezervacija.NovaAkcija = new Action(() => MessageBox.Show("a"));
           }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
