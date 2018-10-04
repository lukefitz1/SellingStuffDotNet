using AutoMapper;
using SellingStuffDotNet.Controllers.Resources;
using SellingStuffDotNet.Models;

namespace SellingStuffDotNet.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API
            CreateMap<Product, ProductResource>();

            // API to Domain
            CreateMap<ProductResource, Product>();
        }
    }
}