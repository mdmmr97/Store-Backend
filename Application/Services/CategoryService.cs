using AutoMapper;
using Store_Backend.Application.Dtos;
using Store_Backend.Domain.Persistence;

namespace Store_Backend.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public List<CategoryDto> GetAllCategories()
        {
            var categories = _categoryRepository.GetAll();
            var categoriesDto = _mapper.Map<List<CategoryDto>>(categories);
            return categoriesDto;
        }
    }
}
