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
        }
    }
}
