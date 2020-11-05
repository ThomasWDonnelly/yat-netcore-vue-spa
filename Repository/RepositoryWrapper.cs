using Yat.NetCore31.Spa.Contracts;

namespace Yat.NetCore31.Spa.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repository;
        // TODO: declare repository interfaces here

        public RepositoryWrapper(RepositoryContext repository)
        {
            _repository = repository;
        }

        // TODO: implement repository interfaces here

        public void Save()
        {
            _repository.SaveChanges();
        }
    }
}