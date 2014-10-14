using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLib;

namespace ProductAdapterLib
{
    public class ProductAdapter:AbstactProduct
    {
        
        public ProductAdapter(SomeExternalVendorProduct externalProduct)
            :base(externalProduct.Description,externalProduct.EANCode,externalProduct.PricePerUnit)
        {
        }
    }
}
