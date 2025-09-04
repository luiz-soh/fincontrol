using Domain.DTOs.Category;
using Domain.Entities.Category;

namespace Application.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task CreateCategory(CreateCategoryDTO dto)
        {
            await _categoryRepository.CreateCategory(dto);
        }
    }
}
