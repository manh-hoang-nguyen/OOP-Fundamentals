using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.BL
{
   public class Order
    {
        public string Customer { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public bool Save()
        {
            return true;
        }
    }
}
