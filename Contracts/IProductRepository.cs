using System.Collections.Generic;
using Yat.NetCore31.Spa.Models;

namespace Yat.NetCore31.Spa.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> GetAllProducts();         
    }
}