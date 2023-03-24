using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.BL
{
    class Product
    {
        public Product(string productName , string productCategory , float productPrice , int availableQuantity , int thresholdQuantity)
        {
            this.productName = productName;
            this.productCategory = productCategory;
            this.productPrice = productPrice;
            this.availableQuantity = availableQuantity;
            this.thresholdQuantity = thresholdQuantity;
        }
        public Product(string productName, string productCategory , float productPrice)
        {
            this.productName = productName;
            this.productCategory = productCategory;
            this.productPrice = productPrice;
        }

        public string productName;
        public string productCategory;
        public float productPrice;
        public int availableQuantity;
        public int thresholdQuantity;
        public float tax;

        public float calculateTax()
        {
            
            if (productCategory == "Grocery")
            {
                 tax = 0.10F * productPrice;
            }
            if (productCategory == "Fruits")
            {
                 tax = 0.5F * productPrice;
            }
          else
            {
                 tax = 0.15F * productPrice;
            }
            return tax;
        }
       
    }
}
