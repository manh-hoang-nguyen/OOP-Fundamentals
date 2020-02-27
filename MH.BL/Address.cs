using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.BL
{
   public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }
        public int AddressId { get;private set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }

        public string City { get; set; }
        public int State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }
        public int AddressType { get;  set; }

    public bool Validate()
        {
            var isValid = true;
            if (PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
