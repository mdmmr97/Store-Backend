using Store_Backend.Domain.Entities;
using Store_Backend.Domain.Persistence;

namespace Store_Backend.Infraestructure.Persistence
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        public ItemRepository(StoreContext storeContext) : base(storeContext)
        {
        }
    }
}
