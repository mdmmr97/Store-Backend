using AutoMapper;
using Store_Backend.Application.Dtos;
using Store_Backend.Domain.Entities;
using Store_Backend.Domain.Persistence;
using Store_Backend.Domain.Services;

namespace Store_Backend.Application.Services
{
    public class ItemService : GenericService<Item, ItemDto>, IItemService
    {
        private IItemRepository _itemRepository;
        private readonly IImageVerifier _imageVerifier;

        public ItemService(IItemRepository repository, IMapper mapper, IImageVerifier imageVerifier) : base(repository, mapper)
        {
            _itemRepository = repository;
            _imageVerifier = imageVerifier;
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

        public override ItemDto Insert(ItemDto dto)
        {
            if (!_imageVerifier.IsImage(dto.Image)) throw new InvalidImageException();
            return base.Insert(dto);
        }

        public override ItemDto Update(ItemDto dto)
        {
            if (!_imageVerifier.IsImage(dto.Image)) throw new InvalidImageException();
            return base.Update(dto);
        }
    }
}
