using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatWPF
{
   public class Order_New_Key
    {
        private string model;
        private bool homeDelivery;

        public Order_New_Key()
        {
        }

        public bool HomeDelivery
        {
            get { return homeDelivery; }
            set { homeDelivery = value; }
        }    
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
    }
}
