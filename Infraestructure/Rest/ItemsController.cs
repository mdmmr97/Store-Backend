 using Microsoft.AspNetCore.Mvc;
using Store_Backend.Application;
using Store_Backend.Application.Dtos;
using Store_Backend.Application.Services;
using Store_Backend.Domain.Services;

namespace Store_Backend.Infraestructure.Rest
{
    [Route("store/[controller]")]
    [ApiController]
    public class ItemsController : GenericCrudController<ItemDto>
    {
        private readonly ILogger<CategoriesController> _logger;
        private IItemService _itemService;

        public ItemsController(IItemService itemService, ILogger<CategoriesController> logger) : base(itemService)
        {
            _itemService = itemService;
            _logger = logger;
        }

        [NonAction]
        public override ActionResult<IEnumerable<ItemDto>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Produces("application/json")]
        public ActionResult<PagedResponse<ItemDto>> Get([FromQuery] string? filter, [FromQuery] PaginationParameters paginationParameters)
        {
            try
            {
                PagedList<ItemDto> page = _itemService.GetItemsByCriteriaPaged(filter, paginationParameters);
                var response = new PagedResponse<ItemDto>
                {
                    CurrentPage = page.CurrentPage,
                    TotalPages = page.TotalPages,
                    PageSize = page.PageSize,
                    TotalCount = page.TotalCount,
                    Data = page
                };
                return Ok(response);

            } catch (MalformedFilterException)
            {
                return BadRequest();
            }
        }

        [HttpGet("/store/categories/{categoryId}/items")]
        [Produces("application/json")]
        public ActionResult<IEnumerable<ItemDto>> GetAllFromCategory(long categoryId)
        {
            var itemsDto = ((IItemService)_service).GetAllByCategoryId(categoryId);
            return Ok(itemsDto);
        }

        public override ActionResult<ItemDto> Insert(ItemDto dto)
        {
            try
            {
                return base.Insert(dto);
            }
            catch (InvalidImageException)
            {
                _logger.LogInformation("Invalid image inserting item with {dto.Name} name", dto.Name);
                return BadRequest();
            }
        }
        public override ActionResult<ItemDto> Update(ItemDto dto)
        {
            try
            {
                return base.Update(dto);
            }
            catch (InvalidImageException)
            {
                _logger.LogInformation("Invalid image updating item with {dto.Id} name", dto.Id);
                return BadRequest();
            }
        }
    }
}
