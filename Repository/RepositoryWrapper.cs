using Yat.NetCore31.Spa.Contracts;

namespace Yat.NetCore31.Spa.Repository
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