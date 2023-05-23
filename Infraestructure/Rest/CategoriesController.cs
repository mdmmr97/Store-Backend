using Microsoft.AspNetCore.Mvc;
using Store_Backend.Application.Dtos;
using Store_Backend.Application.Services;

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
        public ActionResult<CategoryDto> GetCategories()
        {
            var categories = _categoryService.GetAllCategories();
            return Ok(categories);
        }
    }
}
