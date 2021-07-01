using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax
{
    public class Basket
    {
        private List<Goods> goods;
 
        private double saleTax;
        private double total;
        public Basket()
        {
            goods = new List<Goods>();
        }
        public List<Goods> getGoods()
        {
            return goods;
        }
        public double getSaleTax()
        {
            return saleTax;
        }
        public double getTotal()
        {
            return total;
        }
        public void setGoods(Goods goods)
        {
            this.goods.Add(goods);
        }

        public void setSaleTax(double saleTax)
        {
            this.saleTax += saleTax;
        }
        public void setTotal(double total)
        {
            this.total += total;
        }



    }
}
