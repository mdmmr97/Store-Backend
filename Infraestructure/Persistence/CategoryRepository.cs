using Store_Backend.Domain.Entities;
using Store_Backend.Domain.Persistence;

namespace Store_Backend.Infraestructure.Persistence
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private StoreContext _storeContext;

        public CategoryRepository(StoreContext storeContext) : base(storeContext) 
        { 
            _storeContext = storeContext;
        }
    }
}
