using SalesTax.Client;
using SalesTax.Controller;
using System;
using System.Collections.Generic;

namespace SalesTax
{
    class Program
    {


        static void Main(string[] args)
        {
            SalesClient client = new SalesClient();
            client.run();


        }
    }
}
