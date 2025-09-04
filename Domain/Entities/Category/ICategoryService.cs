using Domain.DTOs.Category;

namespace Domain.Entities.Category
{
    public interface ICategoryService
    {
        Task CreateCategory(CategoryDTO dto);
        Task UpdateCategory(CategoryDTO dto);
        Task<CategoryDTO> GetCategoryById(int id);
        Task<List<CategoryDTO>> ListCategories();
        Task DeleteCategoryById(int id);
    }
}
