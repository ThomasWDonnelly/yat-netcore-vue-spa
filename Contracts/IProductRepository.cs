using System.Collections.Generic;
using YatVueApp.Models;

namespace YatVueApp.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> GetAllProducts();         
    }
}