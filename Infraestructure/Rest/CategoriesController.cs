using Microsoft.AspNetCore.Mvc;
using Store_Backend.Application.Dtos;
using Store_Backend.Application.Services;
using Store_Backend.Domain.Services;

namespace Store_Backend.Infraestructure.Rest
{
    [Route("store/[controller]")]
    [ApiController]
    public class CategoriesController:GenericCrudController<CategoryDto>
    {
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ICategoryService categoryService, ILogger<CategoriesController> logger) : base(categoryService)
        {
            _logger = logger;
        }

        public override ActionResult<CategoryDto> Insert(CategoryDto dto)
        {
            try
            {
                return base.Insert(dto);
            }catch (InvalidImageException)
            {
                _logger.LogInformation("Invalid image inserting category with {dto.Name} name", dto.Name);
                return BadRequest();
            }
        }
        public override ActionResult<CategoryDto> Update(CategoryDto dto)
        {
            try
            {
                return base.Update(dto);
            }
            catch (InvalidImageException)
            {
                _logger.LogInformation("Invalid image updating category with {dto.Id} name", dto.Id);
                return BadRequest();
            }
        }
    }
}
