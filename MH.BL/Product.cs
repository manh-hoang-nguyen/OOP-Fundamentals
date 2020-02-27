using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.BL
{
   public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public bool Validate()
        {
            return true;
        }

        public Product Retrieve(int productId)
        {
            return new Product();
        }
        public bool Save()
        {
            return true;
        }

    }
}
