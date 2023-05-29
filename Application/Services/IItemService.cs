using Store_Backend.Application.Dtos;

namespace Store_Backend.Application.Services
{
    public interface IItemService : IGenericService<ItemDto>
    {
        List<ItemDto> GetAllByCategoryId(long categoryId);
        PagedList<ItemDto> GetItemsByCriteriaPaged(string? filter, PaginationParameters paginationParameters);
        List<ItemDto> postNewItemsFromCategory(long categoryId, List<ItemDto> items);
    }
}
