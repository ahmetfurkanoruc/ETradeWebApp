using Core.Utilities.OperationResults;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetProducts();
        IDataResult<List<Product>> GetListByCategory(int categoryId);
        IDataResult<Product> GetProduct(int productId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }
}
