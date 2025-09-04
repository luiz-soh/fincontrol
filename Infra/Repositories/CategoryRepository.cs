using Domain.DTOs.Category;
using Domain.Entities.Category;
using Infra.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class CategoryRepository(ContextBase context) : ICategoryRepository
    {
        private readonly ContextBase _context = context;

        public async Task CreateCategory(CategoryDTO dto)
        {
            var entity = new CategoryEntity()
            {
                Name = dto.Name,
                Type = dto.Type
            };

            _context.Category.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryById(int id) //Bom caso para explicar quando usar e quando não usar o AsNoTracking
        {
            var entity = await _context.Category.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (entity is not null)
            {
                _context.Category.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<CategoryEntity?> GetCategoryById(int id)
        {
            return await _context.Category.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<List<CategoryEntity>> ListCategories()
        {
            return await _context.Category.AsNoTracking().ToListAsync();
        }

        public async Task UpdateCategory(CategoryDTO dto)
        {
            var entity = new CategoryEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
                Type = dto.Type
            };

            _context.Category.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
