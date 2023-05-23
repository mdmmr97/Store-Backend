using AutoMapper;
using Store_Backend.Application.Dtos;
using Store_Backend.Domain.Entities;
using Store_Backend.Domain.Persistence;

namespace Store_Backend.Application.Services
{
    public class CategoryService : GenericService<Category, CategoryDto>, ICategoryService
    {

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper): base(categoryRepository, mapper)
        {
        }
    }
}
