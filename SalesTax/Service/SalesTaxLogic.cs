using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Service
{
    public class SalesTaxLogic
    {
        Basket basket=new Basket();

// List<Goods> goods = new List<Goods>();

        public void addGoodsToBasket(string input)
        {
            Goods goods = convertToGoods(input);
             calculateTax(goods,basket);   
            basket.setGoods(goods);
            

        }
        public Basket getAllGoods()
        {
            return basket;
        }
        static Goods convertToGoods(string input)
        {
            var index = input.LastIndexOf(' ');
            Goods goods = new Goods();
            goods.setName(input.Substring(0, index - 3));
            goods.setPrice(Convert.ToDouble(input.Substring(index + 1)));
            return goods;
        }
        static Basket calculateTax(Goods goods,Basket basket) {
            

            if (goods.getName().Contains("imported"))
            {

                if (goods.getName().Contains("book") || goods.getName().Contains("chocolate") || goods.getName().Contains("pills"))
                {
                    basket.setSaleTax(Math.Round(goods.getPrice() * 0.05, 2, MidpointRounding.AwayFromZero));
                    basket.setTotal(Math.Round(goods.getPrice() + goods.getPrice() * 0.05, 2, MidpointRounding.AwayFromZero));
                    goods.setPrice(Math.Round(goods.getPrice() + goods.getPrice() * 0.05, 2, MidpointRounding.AwayFromZero));
                }
                else
                {
                    basket.setSaleTax(Math.Round(goods.getPrice() * 0.05 + goods.getPrice() * 0.1, 2, MidpointRounding.AwayFromZero));
                    basket.setTotal(Math.Round(goods.getPrice() + goods.getPrice() * 0.05 + +goods.getPrice() * 0.1, 2, MidpointRounding.AwayFromZero));
                    goods.setPrice(Math.Round(goods.getPrice() + goods.getPrice() * 0.05 + goods.getPrice() * 0.1, 2, MidpointRounding.AwayFromZero));
                }
            }
            else
            {
                if (goods.getName().Contains("book") || goods.getName().Contains("chocolate") || goods.getName().Contains("pills"))
                {

                    basket.setTotal(Math.Round(goods.getPrice(), 2, MidpointRounding.AwayFromZero));

                }
                else
                {
                    basket.setSaleTax(Math.Round(goods.getPrice() * 0.1, 2, MidpointRounding.AwayFromZero));
                    basket.setTotal(Math.Round(goods.getPrice() + goods.getPrice() * 0.1, 2, MidpointRounding.AwayFromZero));
                    goods.setPrice(Math.Round(goods.getPrice() + goods.getPrice() * 0.1, 2, MidpointRounding.AwayFromZero));
                }

            }
            return basket;
        }
       
    }
}
