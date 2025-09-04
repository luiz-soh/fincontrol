using Domain.DTOs.Category;
using Domain.Entities.Category;
using Infra.Configuration;

namespace Infra.Repositories
{
    public class CategoryRepository(ContextBase context) : ICategoryRepository
    {
        private readonly ContextBase _context = context;

        public async Task CreateCategory(CreateCategoryDTO dto)
        {
            var entity = new CategoryEntity()
            {
                Name = dto.Name,
                Type = dto.Type
            };

            _context.Category.Add(entity);
            await _context.SaveChangesAsync();
        }
    }
}
