using Domain.DTOs.Category;

namespace Domain.Entities.Category
{
    public interface ICategoryRepository
    {
        Task CreateCategory(CreateCategoryDTO dto);
    }
}
