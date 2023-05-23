using Store_Backend.Application.Dtos;

namespace Store_Backend.Application.Services
{
    public interface ICategoryService
    {
        List<CategoryDto> GetAllCategories();
        CategoryDto GetCategory(long id);
        CategoryDto InsertCategory(CategoryDto categoryDto);
        CategoryDto UpdateCategory(CategoryDto categoryDto);
        void DeteteCategory(long id);
    }
}