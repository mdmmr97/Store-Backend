using Store_Backend.Domain.Entities;

namespace Store_Backend.Domain.Persistence
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
    }
}