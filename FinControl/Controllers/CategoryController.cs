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
            var dto = new CategoryDTO()
            {
                Name = input.Name,
                Type = input.Type,
            };

            await _categoryService.CreateCategory(dto);

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryInput input)
        {
            var dto = new CategoryDTO()
            {
                Id = input.Id,
                Name = input.Name,
                Type = input.Type,
            };

            await _categoryService.UpdateCategory(dto);

            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById([FromRoute] int id)
        {
            var dto = await _categoryService.GetCategoryById(id);

            var response = new CategoryOutput(dto);

            return Ok(response);
        }

        [HttpGet("list")]
        public async Task<IActionResult> ListCategories()
        {
            var dto = await _categoryService.ListCategories();

            var response = dto.Select(x => new CategoryOutput(x)).ToList();

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            await _categoryService.DeleteCategoryById(id);

            return StatusCode(StatusCodes.Status204NoContent);
        }
    }
}
