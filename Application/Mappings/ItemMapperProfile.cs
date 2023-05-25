using AutoMapper;
using Store_Backend.Application.Dtos;
using Store_Backend.Domain.Entities;

namespace Store_Backend.Application.Mappings
{
    public class ItemMapperProfile:Profile
    {
        public ItemMapperProfile() {
            CreateMap<Item, ItemDto>(); 
            CreateMap<ItemDto, Item>();
            CreateMap<PagedList<Item>, PagedList<ItemDto>>()
                .ConvertUsing((src, dest, context) =>
                { 
                    var items = context.Mapper.Map<List<ItemDto>>(src);
                    return new PagedList<ItemDto>(items, src.TotalCount, src.CurrentPage, src.PageSize);
                });
        }
    }
}
