using Store_Backend.Domain.Entities;
using Store_Backend.Domain.Persistence;

namespace Store_Backend.Infraestructure.Persistence
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        public ItemRepository(StoreContext storeContext) : base(storeContext)
        {}

        public List<Item> GetByCategoryId(long categoryId)
        {
            var items = _dbSet.Where(i => i.CategoryId == categoryId);
            if (items == null) return new List<Item>();
            return items.ToList();
        }
    }
}
