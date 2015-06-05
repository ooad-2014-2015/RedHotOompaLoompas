using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatWPF.ViewModels
{
    public class OrderNewKeyView
    {
        public ICommand zatvoriUspjesnuKupovinuKljuca { get; set; }
        public ICommand Upozorenje { get; set; }
        public ICommand Cancel { get; set; }

        public Action MB { get; set; }
        public Action MB2 { get; set; }
        public Action CloseAction { get; set; }
        public Action ProvjeriCombo { get; set; }
        
        public string varijabla{get;set;}

        public OrderNewKeyView()
        {
            Upozorenje = new RelayCommand(u);
            zatvoriUspjesnuKupovinuKljuca = new RelayCommand(zatvori);
            Cancel = new RelayCommand(z);                      
        }

        private void zatvori(object obj)
        {
            this.MB();
            this.CloseAction();
        }
        
        private void z(object obj)
        {    
            this.CloseAction();
        }
        
        private void u(object obj)
        {
           ProvjeriCombo();
           if (varijabla == "") MB2();
           else
           {
               MB();
               CloseAction();
           }

        }
    }
}
