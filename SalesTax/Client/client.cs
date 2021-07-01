using SalesTax.Controller;
using System;

namespace SalesTax.Client
{
    public class SalesClient
    {
        public void run()
        {
            SalesTaxController controller = new SalesTaxController();
            Basket basket;
            bool enter = true;
            Console.WriteLine("To Generate your bill. Enter 'exit' as input");
            Console.WriteLine("Enter Your Input");
            //List<string> basket = new List<string>();
            while (enter)
            {


                string input = Console.ReadLine();


                switch (input)
                {
                    case "exit":
                        enter = false;
                        basket = controller.getAllGoods();
                        foreach (Goods g in basket.getGoods())
                        {
                            Console.WriteLine(g.getName() + ": " + g.getPrice());
                        }
                        Console.WriteLine("Sales Taxs: " + basket.getSaleTax());
                        Console.WriteLine("Total: " + basket.getTotal());
                        break;


                    default:

                        //basket.Add(input);
                       
                        controller.addGoods(input);
                        break;


                }

            }
        }
    }
}
       


