using AutoMapper;
using Store_Backend.Application.Dtos;
using Store_Backend.Domain.Entities;
using Store_Backend.Domain.Persistence;

namespace Store_Backend.Application.Services
{
    public class ItemService : GenericService<Item, ItemDto>, IItemService
    {
        public ItemService(IItemRepository repository, IMapper mapper) : base(repository, mapper)
        {}

        public List<ItemDto> GetAllByCategoryId(long categoryId)
        {
            var items = ((IItemRepository)_repository).GetByCategoryId(categoryId);
            return _mapper.Map<List<ItemDto>>(items);
        }
    }
}
