using Store_Backend.Domain.Entities;

namespace Store_Backend.Domain.Persistence
{
    public interface IItemRepository : IGenericRepository<Item>
    {
        List<Item> GetByCategoryId(long categoryId);
    }
}
