using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductAdapterLib;
using ProductLib;

namespace ProductTestsLib
{
    [TestClass]
    public class AdapterTest
    {
        [TestMethod]
        public void TestProduct()
        {
            IProduct product = new Product() { BarCode = "123456", Title = "Hairdryer", UnitPrice = 120 };
            //Assign
            string expectedTitle = "Hairdryer";
            string expectedBarCode = "123456";
            decimal expectedUnitprice = 120;

            //Act

            string actualTitle = product.Title;
            string actualBarCode = product.BarCode;
            decimal actualUnitprice = product.UnitPrice;

            //Assert
            Assert.AreEqual(expectedTitle, actualTitle);
            Assert.AreEqual(expectedBarCode, actualBarCode);
            Assert.AreEqual(expectedUnitprice, actualUnitprice);
        }

            
            [TestMethod]
        public void TestAdapterProduct()
        {
            ProductAdapterLib.SomeExternalVendorProduct externalProduct = new SomeExternalVendorProduct(){Description = "Hairdryer",EANCode = "123456",PricePerUnit = 120};
            IProduct product = new ProductAdapter(externalProduct);
                //Assign
            string expectedTitle = "Hairdryer";
            string expectedBarCode = "123456";
            decimal expectedUnitprice = 120;
            
            //Act
            
                string actualTitle = product.Title;
                string actualBarCode = product.BarCode;
                decimal actualUnitprice = product.UnitPrice;

            //Assert
            Assert.AreEqual(expectedTitle,actualTitle);
            Assert.AreEqual(expectedBarCode, actualBarCode);
            Assert.AreEqual(expectedUnitprice, actualUnitprice);
        }
            

    }
}
