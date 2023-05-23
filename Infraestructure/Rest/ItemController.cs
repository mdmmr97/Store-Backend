using Microsoft.AspNetCore.Mvc;
using Store_Backend.Application.Dtos;
using Store_Backend.Application.Services;

namespace Store_Backend.Infraestructure.Rest
{
    [Route("store/[controller]")]
    [ApiController]
    public class ItemController : GenericCrudController<ItemDto>
    {
        public ItemController(IItemService itemService) : base(itemService)
        {
        }
    }
}
