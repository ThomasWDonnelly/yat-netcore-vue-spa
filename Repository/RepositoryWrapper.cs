using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YatVueApp.Contracts;

namespace YatVueApp.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repository;
        private IProductRepository _product;

        public RepositoryWrapper(RepositoryContext repository)
        {
            _repository = repository;
        }

        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_repository);
                }
                return _product;
            }
        }

        public void Save()
        {
            _repository.SaveChanges();
        }
    }
}