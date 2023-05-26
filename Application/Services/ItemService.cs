using AutoMapper;
using Store_Backend.Application.Dtos;
using Store_Backend.Domain.Entities;
using Store_Backend.Domain.Persistence;

namespace Store_Backend.Application.Services
{
    public class ItemService : GenericService<Item, ItemDto>, IItemService
    {
        private IItemRepository _itemRepository;

        public ItemService(IItemRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _itemRepository = repository;
        }

        public List<ItemDto> GetAllByCategoryId(long categoryId)
        {
            var items = _itemRepository.GetByCategoryId(categoryId);
            return items;
        }

        public PagedList<ItemDto> GetItemsByCriteriaPaged(string? filter, PaginationParameters paginationParameters)
        {
            var items = _itemRepository.GetItemsByCriteriaPaged(filter, paginationParameters);
            return items;
        }
    }
}
