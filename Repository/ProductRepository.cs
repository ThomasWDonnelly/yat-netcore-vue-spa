using System.Collections.Generic;
using System.Linq;
using Yat.NetCore31.Spa.Contracts;
using Yat.NetCore31.Spa.Models;

namespace Yat.NetCore31.Spa.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repository)
            : base(repository)
        { }

        public IEnumerable<Product> GetAllProducts()
        {
            return FindAll()
                .OrderBy(p => p.Name)
                .ToList();
        }
    }
}