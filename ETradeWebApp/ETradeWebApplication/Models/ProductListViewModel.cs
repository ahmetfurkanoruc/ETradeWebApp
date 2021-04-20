using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETradeWebApplication.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public Product Product { get; set; }

    }
}
