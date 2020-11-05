using AutoMapper;
using Yat.NetCore31.Spa.Contracts;
using Yat.NetCore31.Spa.Models;

namespace Yat.NetCore31.Spa.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
			// AutoMapper mapping profiles
			CreateMap<Product, ProductDto>();
        }
    }
}