using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YatVueApp.Contracts;
using YatVueApp.Models;

namespace YatVueApp.Repository
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