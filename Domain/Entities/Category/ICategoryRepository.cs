using Domain.DTOs.Category;

namespace Domain.Entities.Category
{
    public interface ICategoryRepository
    {
        Task CreateCategory(CategoryDTO dto);
        Task<CategoryEntity?> GetCategoryById(int id);
        Task UpdateCategory(CategoryDTO dto);
        Task<List<CategoryEntity>> ListCategories();
        Task DeleteCategoryById(int id);
    }
}
