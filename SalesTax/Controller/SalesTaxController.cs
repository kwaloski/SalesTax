using SalesTax.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Controller
{
    class SalesTaxController
    {
        SalesTaxLogic service =new SalesTaxLogic();
        public  void addGoods (string input)
        {
            service.addGoodsToBasket(input);

        }
        public Basket getAllGoods()
        {
            return service.getAllGoods();
        }

    }
}
