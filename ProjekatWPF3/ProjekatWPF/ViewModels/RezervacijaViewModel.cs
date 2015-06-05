using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatWPF
{
   public class RezervacijaViewModel
    {

       public Action CloseAction { get; set; }
       public Action NovaAkcija { get; set; }

       public ICommand zatvoriRezervaciju { get; set; }

        public RezervacijaViewModel()
        {
            zatvoriRezervaciju = new RelayCommand(zatvori);
        }
        private void zatvori(object obj)
        {
                NovaAkcija();
                CloseAction();
        }
       

    }
}
