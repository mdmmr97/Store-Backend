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
        {}

        [NonAction]
        public override ActionResult<IEnumerable<ItemDto>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("/store/categories/{categoryId}/items")]
        [Produces("application/json")]
        public ActionResult<IEnumerable<ItemDto>> GetAllFromCategory(long categoryId)
        {
            var categoriesDto = ((IItemService)_service).GetAllByCategoryId(categoryId);
            return Ok(categoriesDto);
        }
    }
}
