using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatWPF.ViewModels
{
   public class TestDriveViewModel
    {
       public Action CloseAction { get; set; }
       public Action MB3 { get; set; }
       public Action ProvjeriButton { get; set; }
       public Action PreuzmiTekst { get; set; }

       public ICommand Upozori { get; set; }
       public ICommand zatvoriTestnu { get; set; }

       public string varijablaZaTestnu { get; set; }
       public bool radio { get; set; }
       
       public TestDriveViewModel() 
       {
           radio = true;
           Upozori = new RelayCommand(u);
           zatvoriTestnu = new RelayCommand(zatvori);
           
       }
       private void u(object obj)
       {
           radio = false;
       }
       private void zatvori(object obj)
        {
            PreuzmiTekst();
            if (varijablaZaTestnu=="" || radio==true)MB3();
            
            else this.CloseAction();
        }
    }
}
