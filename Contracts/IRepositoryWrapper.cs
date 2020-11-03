using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YatVueApp.Contracts
{
    public interface IRepositoryWrapper
    {
        IProductRepository Product { get; }
        
        void Save();
    }
}