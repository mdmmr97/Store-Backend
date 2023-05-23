using Store_Backend.Domain.Entities;
using Store_Backend.Domain.Persistence;

namespace Store_Backend.Infraestructure.Persistence
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreContext _storeContext;

        public CategoryRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public List<Category> GetAll()
        {
            return _storeContext.Categories.ToList<Category>();
        }
    }
}
