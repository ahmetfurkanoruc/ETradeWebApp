using Core.Utilities.OperationResults;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETradeWebApplication.Models
{
    public class CategoryListViewModel
    {
        public Category Category { get; set; }
        public List<Category> Categories { get; set; }
    }
}
