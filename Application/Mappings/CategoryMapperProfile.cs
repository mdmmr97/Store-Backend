using AutoMapper;
using Store_Backend.Application.Dtos;
using Store_Backend.Domain.Entities;

namespace Store_Backend.Application.Mappings
{
    public class CategoryMapperProfile: Profile
    {
        public CategoryMapperProfile() {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
        }
    }
}
