using Domain.DTOs.Category;

namespace Domain.Entities.Category
{
    public interface ICategoryService
    {
        Task CreateCategory(CreateCategoryDTO dto);
    }
}
