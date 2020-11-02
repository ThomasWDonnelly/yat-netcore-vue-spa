using System.Collections.Generic;
using YatVueApp.Model;

namespace YatVueApp.Repository
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> GetAllProducts();         
    }
}