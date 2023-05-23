using Store_Backend.Application.Dtos;

namespace Store_Backend.Application.Services
{
    public interface ICategoryService
    {
        List<CategoryDto> GetAllCategories();
    }
}