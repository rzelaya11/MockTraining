using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPP
{
    public class ProductController
    {
        IRepository repository;

        public ProductController(IRepository repo)
        {
            repository = repo;
        }


        public void TestThis()
        {
            var prods = this.repository.GetProducts();

            foreach (var prod in prods)
            {
                if (prod.name == "Potato")
                    Console.WriteLine("I Want To Buy this");
            }


        }
    }
}
