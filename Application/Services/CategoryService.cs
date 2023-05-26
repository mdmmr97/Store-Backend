using AutoMapper;
using Store_Backend.Application.Dtos;
using Store_Backend.Domain.Entities;
using Store_Backend.Domain.Persistence;
using Store_Backend.Domain.Services;

namespace Store_Backend.Application.Services
{
    public class CategoryService : GenericService<Category, CategoryDto>, ICategoryService
    {
        private ICategoryRepository _categoryRepostory;
        private readonly IImageVerifier _imageVerifier;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper, IImageVerifier imageVerifier) : base(categoryRepository, mapper)
        {
            _categoryRepostory = categoryRepository;
            _imageVerifier = imageVerifier;
        }

        public override CategoryDto Insert(CategoryDto dto)
        {
            if (!_imageVerifier.IsImage(dto.Image)) throw new InvalidImageException();
            return base.Insert(dto);
        }

        public override CategoryDto Update(CategoryDto dto)
        {
            if (!_imageVerifier.IsImage(dto.Image)) throw new InvalidImageException();
            return base.Update(dto);
        }
    }
}
