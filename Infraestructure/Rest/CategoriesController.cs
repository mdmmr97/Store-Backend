using Microsoft.AspNetCore.Mvc;
using Store_Backend.Application.Dtos;
using Store_Backend.Application.Services;

namespace Store_Backend.Infraestructure.Rest
{
    [Route("store/[controller]")]
    [ApiController]
    public class CategoriesController:GenericCrudController<CategoryDto>
    {

        public CategoriesController(ICategoryService categoryService):base(categoryService) { }

    }
}
