using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Product:AbstactProduct
    {
        public Product(string title, string barCode, decimal unitPrice):base(title,barCode,unitPrice)
        {
            
        }
    }
}
