using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPP
{
    public class Repository:IRepository
    {
        public List<Product> GetProducts()
        {
            var listProd = new List<Product>();
            listProd.Add(
                new Product { code="10001",name="Potato",price=15,quantity=300}
                );
            listProd.Add(
                new Product { code = "10002", name = "Apple", price = 15, quantity = 300 }
                );
            listProd.Add(
                new Product { code = "10003", name = "Tomato", price = 15, quantity = 300 }
                );

            return listProd;

        }


    }
}
