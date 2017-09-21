using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPP
{
    class Program
    {
       public static void Main(string[] args)
        {
            var repo = new Repository();
            var prodController = new ProductController(repo);
            Console.ReadKey();

        }
    }
}
