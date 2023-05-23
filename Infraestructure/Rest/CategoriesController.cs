using Microsoft.AspNetCore.Mvc;
using Store_Backend.Application.Dtos;
using Store_Backend.Application.Services;
using Store_Backend.Domain.Persistence;

namespace Store_Backend.Infraestructure.Rest
{
    [Route("store/[controller]")]
    [ApiController]
    public class CategoriesController:ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Produces("application/json")]
        public ActionResult<IEnumerable<CategoryDto>> GetCategories()
        {
            var categories = _categoryService.GetAllCategories();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        [Produces("application/json")]
        public ActionResult<CategoryDto> GetCategory(long id) {
            try {
                CategoryDto categoryDto = _categoryService.GetCategory(id);
                return Ok(categoryDto);
            } catch (ElementNotFoundException) {
                return NotFound();
            }  
        }

        [HttpPost]
        [Produces("application/json")]
        [Consumes("application/json")]
        public ActionResult<CategoryDto> InsertCategory(CategoryDto categoryDto) {
            if (categoryDto == null) return BadRequest();
            categoryDto = _categoryService.InsertCategory(categoryDto);
            return CreatedAtAction(nameof(InsertCategory), new {id = categoryDto.Id}, categoryDto);
        }

        [HttpPut]
        [Produces("application/json")]
        [Consumes("application/json")]
        public ActionResult<CategoryDto> UpdateCategory(CategoryDto categoryDto)
        {
            if (categoryDto == null) return BadRequest();
            categoryDto = _categoryService.UpdateCategory(categoryDto);
            return Ok(categoryDto);
        }

        [HttpDelete("{id}")]
        public ActionResult<CategoryDto> DeteteCategory(long id)
        {
            try
            {
                _categoryService.DeteteCategory(id);
                return NoContent();
            }
            catch (ElementNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
