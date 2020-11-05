namespace Yat.NetCore31.Spa.Contracts
{
    public interface IRepositoryWrapper
    {
        IProductRepository Product { get; }
        
        void Save();
    }
}