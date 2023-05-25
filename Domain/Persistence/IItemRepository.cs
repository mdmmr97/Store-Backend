using Store_Backend.Application.Dtos;
using Store_Backend.Domain.Entities;

namespace Store_Backend.Domain.Persistence
{
    public interface IItemRepository : IGenericRepository<Item>
    {
        List<ItemDto> GetByCategoryId(long categoryId);
    }
}
