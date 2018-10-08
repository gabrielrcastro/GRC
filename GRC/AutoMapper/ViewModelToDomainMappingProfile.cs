using AutoMapper;
using GRC.Application.Models;
using GRC.Domain.Models;

namespace GRC.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Product>()
                .ConstructUsing(c => new Product(c.Id, c.Name, c.CategoryId, c.Price));
            CreateMap<CategoryViewModel, Category>()
                .ConstructUsing(c => new Category(c.Id, c.Name));
        }
    }
}
