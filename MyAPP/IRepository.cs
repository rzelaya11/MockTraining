using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPP
{
    public interface IRepository
    {
        List<Product> GetProducts();
    }
}
