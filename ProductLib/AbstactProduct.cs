﻿namespace ProductLib
{
    public abstract class AbstactProduct:IProduct
    {
        private string title;
        private string barCode;
        private decimal unitPrice;

        public AbstactProduct(string title,string barCode,decimal unitPrice)
        {
            this.title = title;
            this.barCode = barCode;
            this.unitPrice = unitPrice;
        }

        public decimal UnitPrice
        {
            get { return unitPrice; }
        }

        public string BarCode
        {
            get { return barCode; }
        }

        public string Title
        {
            get { return title; }
        }
    }
}
