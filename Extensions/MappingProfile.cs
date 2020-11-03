using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using YatVueApp.Models;
using YatVueApp.Contracts;

namespace YatVueApp.Extensions
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