using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax
{
    public class Goods
    {
         private int count;
        private string type;
       private  string name;
        private double price;

        
        public double getPrice()
        {
            return price;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

    }
}
