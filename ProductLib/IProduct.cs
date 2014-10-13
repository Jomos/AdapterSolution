using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public interface IProduct
    {
        decimal UnitPrice { get; set; }
        string BarCode { get; set; }
        string Title { get; set; }
    }
}
