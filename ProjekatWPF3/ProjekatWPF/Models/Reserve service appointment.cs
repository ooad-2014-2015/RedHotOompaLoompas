using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatWPF
{
    class Reserve_service_appointment
    {
        private DateTime _datumServisa;

        public DateTime DatumServisa
        {
            get { return _datumServisa; }
            set { _datumServisa = value; }
        }
    }
}
