using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLib;

namespace ProductAdapterLib
{
    public class ProductAdapter:IProduct
    {
        public decimal UnitPrice { get; set; }

        public string BarCode { get; set; }

        public string Title { get; set; }

        public ProductAdapter(SomeExternalVendorProduct externalProduct)
        {
            Title = externalProduct.Description;
            UnitPrice = externalProduct.PricePerUnit;
            BarCode = externalProduct.EANCode;
        }
    }
}
