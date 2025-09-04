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
        public async Task CreateCategory(CategoryDTO dto)
        {
            await _categoryRepository.CreateCategory(dto);
        }

        public async Task DeleteCategoryById(int id)
        {
            await _categoryRepository.DeleteCategoryById(id);
        }

        public async Task<CategoryDTO> GetCategoryById(int id)
        {
            var entity = await _categoryRepository.GetCategoryById(id);
            if (entity == null)
            {
                return new CategoryDTO();
            }

            return new CategoryDTO()
            {
                Id = entity.Id,
                Name = entity.Name,
                Type = entity.Type,
            };
        }

        public async Task<List<CategoryDTO>> ListCategories()
        {
            var entities = await _categoryRepository.ListCategories();
            return entities.Select(x => new CategoryDTO(x)).ToList();
        }

        public async Task UpdateCategory(CategoryDTO dto)
        {
            var categoryExists = await _categoryRepository.GetCategoryById(dto.Id);
            if (categoryExists != null)
            {
                await _categoryRepository.UpdateCategory(dto);
            }
        }
    }
}
