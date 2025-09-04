using Domain.Entities.Category;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configuration
{
    public class ContextBase(DbContextOptions<ContextBase> options) : DbContext(options)
    {
        public DbSet<CategoryEntity> Category => Set<CategoryEntity>();
    }
}
