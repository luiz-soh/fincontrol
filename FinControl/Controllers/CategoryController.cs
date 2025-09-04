using Application.Category.Boundaries;
using Domain.DTOs.Category;
using Domain.Entities.Category;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryInput input)
        {
            var dto = new CreateCategoryDTO()
            {
                Name = input.Name,
                Type = input.Type,
            };

            await _categoryService.CreateCategory(dto);

            return Ok();
        }
    }
}
