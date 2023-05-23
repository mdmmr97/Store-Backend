using Store_Backend.Domain.Entities;

namespace Store_Backend.Domain.Persistence
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        object GetById(long id);
        Category Insert(Category category);
        Category Update(Category category);
        void Delete(long id);
    }
}